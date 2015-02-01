﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace FishBench
{
    class Tester
    {
        private int amount;
        private string pathA, pathB;
        private decimal sumA, sumB;
        private int completedA, completedB;

        private List<decimal> listA, listB;

        public event EventHandler TestFinished, JobFinished;
        private bool jobInProgress;
        private Thread job;

        public int Completed { get { return completedA + completedB; } }
        public int CompletedEach { get { return completedB; } }

        public double PercentCompleted
        {
            get
            {
                return (double)(completedA + completedB) / (double)(Amount) * (double)100;
            }
        }

        public void AbortJob()
        {
            if (jobInProgress && !abortJob)
                abortJob = true;
        }

        public int Amount
        {
            get { return amount * 2; }
            set
            {
                if (!jobInProgress && value > 0)
                    amount = value;
            }
        }

        public long AverageA
        {
            get { return (long)(completedA == 0 ? 0 : sumA / (decimal)completedA); }
        }

        public long AverageB
        {
            get { return (long)(completedB == 0 ? 0 : sumB / (decimal)completedB); }
        }

        public long AverageDiff
        {
            get
            {
                return AverageA - AverageB;
            }
        }

        public long StdevA
        {
            get
            {
                long avg = AverageA;
                return completedA <= 1 ?
                    0 : (long)Math.Sqrt( (long)listA.Select(d => (d - avg) * (d - avg)).Sum() / (long)(completedA - 1) );
            }
        }

        public long StdevB
        {
            get
            {
                long avg = AverageB;
                return completedB <= 1 ?
                    0 : (long)Math.Sqrt((long)listB.Select(d => (d - avg) * (d - avg)).Sum() / (long)(completedB - 1) );
            }
        }

        public long StdevDiff
        {
            get
            {
                long avg = AverageDiff, sum = 0;
                int len = Math.Min(listA.Count, listB.Count);
                for (int i = 0; i < len; i++)
                {
                    long cur = (long)listA[i] - (long)listB[i] - avg;
                    cur *= cur;
                    sum += cur;
                }
                return len <= 1 ? 0 : (long)Math.Sqrt(sum / (len - 1));
            }
        }

        public double p_value
        {
            get
            {
                return Normal.CDF(AverageDiff, StdevDiff, 0);
            }
        }

        public double speedup
        {
            get
            {
                return (-(double)AverageDiff) / (double)AverageA;
            }
        }
        public Tester(string pathA, string pathB)
        {
            this.pathA = pathA;
            this.pathB = pathB;
            amount = 5;
            completedA = completedB = 0;
            jobInProgress = false;
        }
        public Tester() : this("", "") { }
        public void SetPathes(string pathA, string pathB)
        {
            this.pathA = pathA;
            this.pathB = pathB;
        }
        public void WaitJobEnd()
        {
            if (job != null && jobInProgress)
                job.Join();
        }

        private bool abortJob = false;
        private void doJob()
        {
            jobInProgress = true;
            listA = new List<decimal>(amount);
            listB = new List<decimal>(amount);

            int amountD = amount;
            decimal obs;
            string[] sep = {": "};
            sumA = sumB = completedA = completedB = 0;
            ProcessStartInfo infoA = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = pathA,
                Arguments = "bench",
                //FileName = "cmd.exe",
                //Arguments = "/c start /B /REALTIME /AFFINITY 0x1 \"" + pathA + "\" bench 1>nul",
                RedirectStandardError = true
            }, infoB = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = pathB,
                Arguments = "bench",
                //FileName = "cmd.exe",
                //Arguments = "/c start /B /REALTIME /AFFINITY 0x1 \"" + pathB + "\" bench 1>nul",
                RedirectStandardError = true
            };

            for (int i = 0; i < amountD; i++)
            {
                Process pa = new Process();
                pa.StartInfo = infoA;
                Process pb = new Process();
                pb.StartInfo = infoB;

                if (i % 2 == 0)
                {
                    pa.Start();
                    pb.Start();
                }
                else
                {
                    pb.Start();
                    pa.Start();
                }

                string lineA = "";
                while (!(lineA = pa.StandardError.ReadLine()).StartsWith("Nodes/second")) ;
                obs = decimal.Parse(lineA
                    .Split(sep, 2, StringSplitOptions.RemoveEmptyEntries)[1]);
                sumA += obs;
                listA.Add(obs);
                completedA++;

                string lineB = "";
                while (!(lineB = pb.StandardError.ReadLine()).StartsWith("Nodes/second")) ;
                obs = decimal.Parse(lineB
                    .Split(sep, 2, StringSplitOptions.RemoveEmptyEntries)[1]);
                sumB += obs;
                listB.Add(obs);
                completedB++;


                if (TestFinished != null)
                    TestFinished(this, EventArgs.Empty);
                if (abortJob)
                {
                    jobInProgress = false;
                    abortJob = false;
                    return;
                }
            }
            if (JobFinished != null)
                JobFinished(this, EventArgs.Empty);

            jobInProgress = false;
            abortJob = false;
        }

        public void DoJob()
        {
            if (jobInProgress) return;
            job = new Thread(doJob);
            job.Start();
        }
    }
}
