namespace Xterra2Input
{
    partial class Form1
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
            this.threshhold = new System.Windows.Forms.NumericUpDown();
            this.inputDelay = new System.Windows.Forms.NumericUpDown();
            this.threshold = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.micDb = new System.Windows.Forms.ProgressBar();
            this.loopWorker = new System.ComponentModel.BackgroundWorker();
            this.peakValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keyComboBox = new System.Windows.Forms.ComboBox();
            this.enableButtonPresses = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.threshhold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // threshhold
            // 
            this.threshhold.DecimalPlaces = 6;
            this.threshhold.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.threshhold.Location = new System.Drawing.Point(106, 19);
            this.threshhold.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.threshhold.Name = "threshhold";
            this.threshhold.Size = new System.Drawing.Size(111, 20);
            this.threshhold.TabIndex = 0;
            this.threshhold.Value = new decimal(new int[] {
            38,
            0,
            0,
            131072});
            // 
            // inputDelay
            // 
            this.inputDelay.Location = new System.Drawing.Point(106, 45);
            this.inputDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.inputDelay.Name = "inputDelay";
            this.inputDelay.Size = new System.Drawing.Size(111, 20);
            this.inputDelay.TabIndex = 1;
            this.inputDelay.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // threshold
            // 
            this.threshold.AutoSize = true;
            this.threshold.Location = new System.Drawing.Point(6, 21);
            this.threshold.Name = "threshold";
            this.threshold.Size = new System.Drawing.Size(54, 13);
            this.threshold.TabIndex = 2;
            this.threshold.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Delay (ms)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.threshold);
            this.groupBox1.Controls.Add(this.inputDelay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.threshhold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Key to Input";
            // 
            // micDb
            // 
            this.micDb.Location = new System.Drawing.Point(12, 162);
            this.micDb.MarqueeAnimationSpeed = 1;
            this.micDb.Maximum = 101;
            this.micDb.Name = "micDb";
            this.micDb.Size = new System.Drawing.Size(223, 23);
            this.micDb.TabIndex = 5;
            // 
            // loopWorker
            // 
            this.loopWorker.WorkerReportsProgress = true;
            this.loopWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.loopWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.loopWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // peakValue
            // 
            this.peakValue.Enabled = false;
            this.peakValue.Location = new System.Drawing.Point(118, 136);
            this.peakValue.Name = "peakValue";
            this.peakValue.Size = new System.Drawing.Size(117, 20);
            this.peakValue.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peak Value";
            // 
            // keyComboBox
            // 
            this.keyComboBox.FormattingEnabled = true;
            this.keyComboBox.Location = new System.Drawing.Point(106, 73);
            this.keyComboBox.Name = "keyComboBox";
            this.keyComboBox.Size = new System.Drawing.Size(111, 21);
            this.keyComboBox.TabIndex = 5;
            // 
            // enableButtonPresses
            // 
            this.enableButtonPresses.AutoSize = true;
            this.enableButtonPresses.Location = new System.Drawing.Point(13, 119);
            this.enableButtonPresses.Name = "enableButtonPresses";
            this.enableButtonPresses.Size = new System.Drawing.Size(133, 17);
            this.enableButtonPresses.TabIndex = 8;
            this.enableButtonPresses.Text = "Enable Button Presses";
            this.enableButtonPresses.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 195);
            this.Controls.Add(this.enableButtonPresses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peakValue);
            this.Controls.Add(this.micDb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Xterra2Input";
            ((System.ComponentModel.ISupportInitialize)(this.threshhold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown threshhold;
        private System.Windows.Forms.NumericUpDown inputDelay;
        private System.Windows.Forms.Label threshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar micDb;
        private System.ComponentModel.BackgroundWorker loopWorker;
        private System.Windows.Forms.TextBox peakValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox keyComboBox;
        private System.Windows.Forms.CheckBox enableButtonPresses;
    }
}

