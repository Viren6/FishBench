﻿namespace FishBench
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseLocationText = new System.Windows.Forms.TextBox();
            this.stockfishLocationText = new System.Windows.Forms.TextBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.stockfishLabel = new System.Windows.Forms.Label();
            this.baseBrowseButton = new System.Windows.Forms.Button();
            this.stockfishBrowseButton = new System.Windows.Forms.Button();
            this.amountTestNumeric = new System.Windows.Forms.NumericUpDown();
            this.amountTestsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressMessage = new System.Windows.Forms.Label();
            this.terminateButton = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountTestNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // baseLocationText
            // 
            this.baseLocationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLocationText.Location = new System.Drawing.Point(126, 12);
            this.baseLocationText.Name = "baseLocationText";
            this.baseLocationText.Size = new System.Drawing.Size(277, 20);
            this.baseLocationText.TabIndex = 0;
            this.baseLocationText.TextChanged += new System.EventHandler(this.locationText_TextChanged);
            // 
            // stockfishLocationText
            // 
            this.stockfishLocationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockfishLocationText.Location = new System.Drawing.Point(126, 38);
            this.stockfishLocationText.Name = "stockfishLocationText";
            this.stockfishLocationText.Size = new System.Drawing.Size(277, 20);
            this.stockfishLocationText.TabIndex = 1;
            this.stockfishLocationText.TextChanged += new System.EventHandler(this.locationText_TextChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(12, 15);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(74, 13);
            this.baseLabel.TabIndex = 1;
            this.baseLabel.Text = "Base location:";
            // 
            // stockfishLabel
            // 
            this.stockfishLabel.AutoSize = true;
            this.stockfishLabel.Location = new System.Drawing.Point(12, 41);
            this.stockfishLabel.Name = "stockfishLabel";
            this.stockfishLabel.Size = new System.Drawing.Size(108, 13);
            this.stockfishLabel.TabIndex = 1;
            this.stockfishLabel.Text = "Test version location:";
            // 
            // baseBrowseButton
            // 
            this.baseBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseBrowseButton.Location = new System.Drawing.Point(410, 12);
            this.baseBrowseButton.Name = "baseBrowseButton";
            this.baseBrowseButton.Size = new System.Drawing.Size(27, 20);
            this.baseBrowseButton.TabIndex = 2;
            this.baseBrowseButton.Text = "...";
            this.baseBrowseButton.UseVisualStyleBackColor = true;
            this.baseBrowseButton.Click += new System.EventHandler(this.baseBrowseButton_Click);
            // 
            // stockfishBrowseButton
            // 
            this.stockfishBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockfishBrowseButton.Location = new System.Drawing.Point(409, 38);
            this.stockfishBrowseButton.Name = "stockfishBrowseButton";
            this.stockfishBrowseButton.Size = new System.Drawing.Size(27, 20);
            this.stockfishBrowseButton.TabIndex = 2;
            this.stockfishBrowseButton.Text = "...";
            this.stockfishBrowseButton.UseVisualStyleBackColor = true;
            this.stockfishBrowseButton.Click += new System.EventHandler(this.stockfishBrowseButton_Click);
            // 
            // amountTestNumeric
            // 
            this.amountTestNumeric.Location = new System.Drawing.Point(196, 63);
            this.amountTestNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountTestNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountTestNumeric.Name = "amountTestNumeric";
            this.amountTestNumeric.Size = new System.Drawing.Size(78, 20);
            this.amountTestNumeric.TabIndex = 3;
            this.amountTestNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountTestsLabel
            // 
            this.amountTestsLabel.AutoSize = true;
            this.amountTestsLabel.Location = new System.Drawing.Point(12, 66);
            this.amountTestsLabel.Name = "amountTestsLabel";
            this.amountTestsLabel.Size = new System.Drawing.Size(178, 13);
            this.amountTestsLabel.TabIndex = 1;
            this.amountTestsLabel.Text = "Amount of tests (for each Stockfish):";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(280, 61);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(113, 91);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(323, 23);
            this.progressBar.TabIndex = 5;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 91);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(51, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "Progress:";
            // 
            // progressMessage
            // 
            this.progressMessage.AutoSize = true;
            this.progressMessage.Location = new System.Drawing.Point(113, 121);
            this.progressMessage.Name = "progressMessage";
            this.progressMessage.Size = new System.Drawing.Size(69, 13);
            this.progressMessage.TabIndex = 6;
            this.progressMessage.Text = "Finished: 0/0";
            // 
            // terminateButton
            // 
            this.terminateButton.Enabled = false;
            this.terminateButton.Location = new System.Drawing.Point(361, 61);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(75, 23);
            this.terminateButton.TabIndex = 4;
            this.terminateButton.Text = "Terminate";
            this.terminateButton.UseVisualStyleBackColor = true;
            this.terminateButton.Click += new System.EventHandler(this.terminateButton_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.Location = new System.Drawing.Point(15, 150);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(307, 124);
            this.resultsBox.TabIndex = 20;
            this.resultsBox.Text = "Results for 0 tests for each version:\r\n\r\n            Base      Test      Diff    " +
    "  \r\n    Mean    0         0         0         \r\n    StDev   0         0         " +
    "0         \r\n\r\np-value: 0\r\nspeedup: 0";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(328, 250);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(89, 23);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 285);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.progressMessage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.terminateButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.amountTestNumeric);
            this.Controls.Add(this.stockfishBrowseButton);
            this.Controls.Add(this.baseBrowseButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.amountTestsLabel);
            this.Controls.Add(this.stockfishLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.stockfishLocationText);
            this.Controls.Add(this.baseLocationText);
            this.Name = "MainForm";
            this.Text = "FishBench";
            ((System.ComponentModel.ISupportInitialize)(this.amountTestNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox baseLocationText;
        private System.Windows.Forms.TextBox stockfishLocationText;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label stockfishLabel;
        private System.Windows.Forms.Button baseBrowseButton;
        private System.Windows.Forms.Button stockfishBrowseButton;
        private System.Windows.Forms.NumericUpDown amountTestNumeric;
        private System.Windows.Forms.Label amountTestsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label progressMessage;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox resultsBox;
    }
}

