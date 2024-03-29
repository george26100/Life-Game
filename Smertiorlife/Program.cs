using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smertiorlife
{
    internal static class Program
    {
        private static int cols;
        private static int rows;
        private static int resolution;
        private static int[,] field;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TheGameOfLife());
        }
    }
}
