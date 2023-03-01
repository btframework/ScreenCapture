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
