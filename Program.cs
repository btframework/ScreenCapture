/*
 * Copyright (C) 2023 Marina Petrichenko
 * 
 * marina@btframework.com  
 *   https://www.facebook.com/marina.petrichenko.1  
 *   https://www.btframework.com
 * 
 * It is free for non-commercial and/or education use only.
 *   
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScreenCapture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }
    }
}
