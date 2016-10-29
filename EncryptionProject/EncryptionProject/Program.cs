using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
Napredni operacijski sustavi (2015/16)
- 1. i 2. laboratorijska vjezba
(Digitalni potpis i Kriptografski algoritam)
- Datum predaje: 27.03.2016.
- Autor: Josip Milic (0036456339)
*/

namespace EncryptionProject
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
            Application.Run(new MainForm());
        }
    }
}
