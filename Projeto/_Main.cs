using System;
using System.Windows.Forms;

namespace CalculadoraCH
{
    static class _Main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculadoraCH());
        }
    }
}
