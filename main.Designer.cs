
namespace ScreenCapture
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.laImageDirectory = new System.Windows.Forms.Label();
            this.edDirectory = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btStop = new System.Windows.Forms.Button();
            this.laInterval = new System.Windows.Forms.Label();
            this.edInterval = new System.Windows.Forms.NumericUpDown();
            this.laSeconds = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(67, 71);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // laImageDirectory
            // 
            this.laImageDirectory.AutoSize = true;
            this.laImageDirectory.Location = new System.Drawing.Point(12, 22);
            this.laImageDirectory.Name = "laImageDirectory";
            this.laImageDirectory.Size = new System.Drawing.Size(49, 13);
            this.laImageDirectory.TabIndex = 1;
            this.laImageDirectory.Text = "Directory";
            // 
            // edDirectory
            // 
            this.edDirectory.Location = new System.Drawing.Point(67, 19);
            this.edDirectory.Name = "edDirectory";
            this.edDirectory.Size = new System.Drawing.Size(267, 20);
            this.edDirectory.TabIndex = 2;
            this.edDirectory.Text = "d:\\Capture";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(340, 17);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(75, 23);
            this.btSelect.TabIndex = 3;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(148, 71);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // laInterval
            // 
            this.laInterval.AutoSize = true;
            this.laInterval.Location = new System.Drawing.Point(12, 47);
            this.laInterval.Name = "laInterval";
            this.laInterval.Size = new System.Drawing.Size(42, 13);
            this.laInterval.TabIndex = 5;
            this.laInterval.Text = "Interval";
            // 
            // edInterval
            // 
            this.edInterval.Location = new System.Drawing.Point(67, 45);
            this.edInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edInterval.Name = "edInterval";
            this.edInterval.Size = new System.Drawing.Size(66, 20);
            this.edInterval.TabIndex = 6;
            this.edInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // laSeconds
            // 
            this.laSeconds.AutoSize = true;
            this.laSeconds.Location = new System.Drawing.Point(139, 47);
            this.laSeconds.Name = "laSeconds";
            this.laSeconds.Size = new System.Drawing.Size(47, 13);
            this.laSeconds.TabIndex = 7;
            this.laSeconds.Text = "seconds";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 101);
            this.Controls.Add(this.laSeconds);
            this.Controls.Add(this.edInterval);
            this.Controls.Add(this.laInterval);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.edDirectory);
            this.Controls.Add(this.laImageDirectory);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Captgure Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.edInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label laImageDirectory;
        private System.Windows.Forms.TextBox edDirectory;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label laInterval;
        private System.Windows.Forms.NumericUpDown edInterval;
        private System.Windows.Forms.Label laSeconds;
        private System.Windows.Forms.Timer timer;
    }
}

