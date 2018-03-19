using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678
{
    public partial class DateTimeForm : Form
    {
        string oldText;

        public DateTimeForm()
        {
            InitializeComponent();

            this.Load += DateTimeForm_Load;
        }

        private void DateTimeForm_Load(object sender, EventArgs e)
        {
            UserDate.Text = "";
            oldText = "";

            UserDate.TextChanged += UserDate_TextChanged;

            UserDate.KeyDown += UserDate_KeyDown;
            UserDate.KeyUp += UserDate_KeyUp;
            UserDate.KeyPress += UserDate_KeyPress;

            ClearButton.Click += ClearButton_Click;

            CalculateButton.Click += CalculateButton_Click;
        }

        private void UserDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            //Для проверки ввода только цифр

            if (!Char.IsDigit(key))
            {
                e.Handled = true;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            GetDayFromDate();
        }

        private void UserDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                UserDate.Text = oldText;
            }
        }

        private void UserDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                oldText = UserDate.Text;
            }

            if (e.KeyCode == Keys.Enter)
            {
                if(UserDate.Text.Length == 10)
                {
                    GetDayFromDate();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalculateButton.Enabled = false;
            ResultTextLabel.Visible = false;
            ResultText.Visible = false;
            UserDate.Text = "";
        }

        private void UserDate_TextChanged(object sender, EventArgs e)
        {


            TextBox tb = sender as TextBox;

            if (tb.Text.Length != 0)
            {
                ClearButton.Enabled = true;
            }
            else
            {
                ClearButton.Enabled = false;
            }

            if (tb.Text.Length == 4 || tb.Text.Length == 7)
            {
                tb.Text += '-';
                tb.SelectionStart = tb.Text.Length + 1;
            }

            if(tb.Text.Length == 10)
            {
                CalculateButton.Enabled = true;
            }
            else
            {
                CalculateButton.Enabled = false;
            }

        }

        private void GetDayFromDate()
        {

            string day;

            try
            {
                ResultTextLabel.Visible = true;
                ResultText.Visible = true;
                DateTime userDate;
                DateTime.TryParse(UserDate.Text, out userDate);
                day = userDate.DayOfWeek.ToString();
                CalculateButton.Enabled = false;

                switch(day)
                {
                    case "Mondey":
                        ResultText.Text = "Понедельник";
                        break;
                    case "Tuesday":
                        ResultText.Text = "Вторник";
                        break;
                    case "Wednesday":
                        ResultText.Text = "Среда";
                        break;
                    case "Thursday":
                        ResultText.Text = "Четверг";
                        break;
                    case "Friday":
                        ResultText.Text = "Пятница";
                        break;
                    case "Saturday":
                        ResultText.Text = "Суббота";
                        break;
                    case "Sunday":
                        ResultText.Text = "Воскресенье";
                        break;
                    default:
                        ResultText.Text = day;
                        break;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Вы ввели не правельную дату!", "Count day From");
            }
        }
    }
}
