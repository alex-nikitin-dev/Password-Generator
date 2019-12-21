using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PassGenerator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}