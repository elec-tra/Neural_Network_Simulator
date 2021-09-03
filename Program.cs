/*
 ============================================================================
 Name        : Neural Netwok Simulator
 Author      : Saranyan
 Version     : 1.0
 Copyright   : Copyright 2020, Saranyan, All rights reserved.
 Description : This is a simple neural network developed in windows forms.
 ============================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AIComputingGraphics
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
            Application.Run(new Form1());
        }
    }
}
