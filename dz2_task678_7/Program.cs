/*
 Написать программу, вычисляющую сколько осталось времени до указанной даты 
 (дата вводится с клавиатуры в Edit). Предусмотреть возможность выдачи результата в 
    годах, 
    месяцах, 
    днях, 
    минутах, 
    секундах 
    (для первых двух вариантов ответ дробный). 
Для переключения между вариантами желательно использовать переключатели (RadioButton).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678_7
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
