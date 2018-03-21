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
        bool notDate;

        public DateTimeForm()
        {
            InitializeComponent();

            this.Load += DateTimeForm_Load;
        }

        private void DateTimeForm_Load(object sender, EventArgs e)
        {
            UserDate.Text = "";
            oldText = "";
            notDate = false;

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
            if (!notDate)
            {
                GetDayFromDate();
            }
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

            if (e.KeyCode == Keys.Enter && !notDate)
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
            notDate = false;
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
                DateTime userDate;
                DateTime.TryParse(UserDate.Text, out userDate);

                if (userDate.ToString() == "01.01.01 00:00:00")
                {
                    throw new Exception("Не правильная дата");
                }

                day = userDate.DayOfWeek.ToString();
                CalculateButton.Enabled = false;

                ResultTextLabel.Visible = true;
                ResultText.Visible = true;

                switch (day)
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
            catch (Exception e)
            {
                notDate = true;
                MessageBox.Show(e.Message);
            }
        }
    }
}
