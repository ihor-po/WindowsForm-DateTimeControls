/*
   Написать программу, которая по введенной дате определяет день недели. 
   Результат выводить в текстовое поле (желательно по-русски).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678
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
            Application.Run(new DateTimeForm());
        }
    }
}
