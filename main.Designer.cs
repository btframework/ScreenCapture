
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miStart = new System.Windows.Forms.ToolStripMenuItem();
            this.miStop = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.edInterval)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
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
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Screen capture";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStart,
            this.miStop,
            this.miSettings,
            this.toolStripSeparator1,
            this.miExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 98);
            // 
            // miStart
            // 
            this.miStart.Name = "miStart";
            this.miStart.Size = new System.Drawing.Size(125, 22);
            this.miStart.Text = "Start";
            this.miStart.Click += new System.EventHandler(this.miStart_Click);
            // 
            // miStop
            // 
            this.miStop.Enabled = false;
            this.miStop.Name = "miStop";
            this.miStop.Size = new System.Drawing.Size(125, 22);
            this.miStop.Text = "Stop";
            this.miStop.Click += new System.EventHandler(this.miStop_Click);
            // 
            // miSettings
            // 
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(125, 22);
            this.miSettings.Text = "Settings...";
            this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(125, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
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
            this.Text = "Screen Capture Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Resize += new System.EventHandler(this.fmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.edInterval)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miStart;
        private System.Windows.Forms.ToolStripMenuItem miStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
    }
}

