/*
 * Copyright (C) 2023 Marina Petrichenko
 * -------------------------------------
 *   marina@btframework.com
 *   https://www.facebook.com/marina.petrichenko.1
 *   
 *   It is free for non-commercial and/or education use only.
 *   
 *   If you use all or any part of this code in your commercial, non-commercial, education, open source
 *   or any other application your application/project/product/work source code must also be opened.
 *   
 *   If you want to use it in any kind of closed source product contact me and we discuss the price.
 *   
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class fmMain : Form
    {
        private Dictionary<String, Bitmap> CaptureScreen()
        {
            Dictionary<String, Bitmap> result = new Dictionary<String, Bitmap>();
            foreach (Screen screen in Screen.AllScreens)
            {
                Bitmap bitmap = new Bitmap(screen.Bounds.Width, screen.Bounds.Height,
                    PixelFormat.Format32bppArgb);
                Rectangle rectangle = screen.Bounds;
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(rectangle.Left, rectangle.Top, 0, 0, rectangle.Size);
                
                result.Add(screen.DeviceName.Replace("\\", "").Replace(".", ""), bitmap);
                
                graphics.Dispose();
            }
            return result;
        }

        private void SaveBitmaps()
        {
            if (!Directory.Exists(edDirectory.Text))
                Directory.CreateDirectory(edDirectory.Text);

            Dictionary<String, Bitmap> bitmaps = CaptureScreen();
            if (bitmaps.Count > 0)
            {
                foreach (KeyValuePair<String, Bitmap> picture in bitmaps)
                {
                    String screenName = picture.Key;
                    Bitmap bitmap = picture.Value;
                    try
                    {
                        String fileName = edDirectory.Text + "\\_" + screenName +
                                "_" + Environment.TickCount.ToString() + "_capture.jpg";
                        bitmap.Save(fileName, ImageFormat.Jpeg);
                    }
                    finally
                    {
                        bitmap.Dispose();
                    }
                }
            }
            bitmaps.Clear();
        }

        private void EnableUi()
        {
            btSelect.Enabled = !timer.Enabled;
            edDirectory.Enabled = !timer.Enabled;
            btStart.Enabled = !timer.Enabled;
            edInterval.Enabled = !timer.Enabled;
            btStop.Enabled = timer.Enabled;
            miStart.Enabled = !timer.Enabled;
            miStop.Enabled = timer.Enabled;
        }

        private void StartCapture()
        {
            if (edDirectory.Text == "")
                MessageBox.Show("Provide directory");
            else
            {
                timer.Interval = (int)edInterval.Value * 1000;
                timer.Start();
                EnableUi();
            }
        }

        private void StopCapture()
        {
            timer.Stop();
            EnableUi();
        }

        private void ShowSettings()
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public fmMain()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (edDirectory.Text != "")
                folderBrowserDialog.SelectedPath = edDirectory.Text;
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                edDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaveBitmaps();
        }

        private void fmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowSettings();
        }

        private void miStart_Click(object sender, EventArgs e)
        {
            StartCapture();
        }

        private void miStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miSettings_Click(object sender, EventArgs e)
        {
            ShowSettings();
        }
    }
}
