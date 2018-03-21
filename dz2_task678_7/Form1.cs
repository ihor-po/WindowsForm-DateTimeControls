using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678_7
{
    public partial class MainForm : Form
    {
        string oldText;
        bool notDate;
        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserDate.Text = "";
            ResCalcLabel.Text = "";
            oldText = "";
            notDate = false;

            UserDate.TextChanged += UserDate_TextChanged;
            UserDate.KeyDown += UserDate_KeyDown;
            UserDate.KeyUp += UserDate_KeyUp;
            UserDate.KeyPress += UserDate_KeyPress;

            CalculateButton.Click += CalculateButton_Click;
            ClearButton.Click += ClearButton_Click;

            ExitB.Click += ExitB_Click;
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

        private void ExitB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!notDate)
            {
                CalculatingResult();
            }
        }

        private void RbYear_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserDate.Text = "";
            ClearButton.Enabled = false;
            notDate = false;
            CalculateButton.Enabled = false;
            ResTextLabel.Visible = false;
            ResCalcLabel.Visible = false;
            ClearButton.Enabled = false;
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
                if (UserDate.Text.Length == 10 && !notDate)
                {
                    CalculatingResult();
                }
            }
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

            if (tb.Text.Length == 10)
            {
                CalculateButton.Enabled = true;
            }
            else
            {
                CalculateButton.Enabled = false;
            }
        }

        private void CalculatingResult()
        {
            double month_yaer;
            try
            {
                DateTime userDate;
                DateTime.TryParse(UserDate.Text, out userDate);

                if (userDate.ToString() == "01.01.01 00:00:00")
                {
                    throw new Exception("Не правильная дата");
                }

                DateTime dateNow = DateTime.Now;

                if(userDate < dateNow)
                {
                    throw new Exception("Давайте смотреть вперед!\rРезультат который Вам нужен - уже история");
                }

                RadioButton checkedB = RadioGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

                switch (checkedB.Name)
                {
                    case "rbYear":
                        
                        month_yaer = Math.Round(userDate.Subtract(dateNow).TotalDays / (double)365, 2);
                        ResCalcLabel.Text = month_yaer.ToString();
                        break;
                    case "rbMonth":
                        month_yaer = userDate.Subtract(dateNow).TotalDays / (double)365;
                        month_yaer *= 12; 
                        ResCalcLabel.Text = (Math.Round(month_yaer, 2)).ToString();
                        break;
                    case "rbDay":
                        ResCalcLabel.Text = Convert.ToInt32(userDate.Subtract(dateNow).TotalDays).ToString();
                        break;
                    case "rbMinute":
                        ResCalcLabel.Text = Convert.ToInt64(userDate.Subtract(dateNow).TotalMinutes).ToString();
                        break;
                    case "rbSeconds":
                        ResCalcLabel.Text = Convert.ToInt64(userDate.Subtract(dateNow).TotalSeconds).ToString();
                        break;
                }

                ResTextLabel.Visible = true;
                ResCalcLabel.Visible = true;
            }
            catch (Exception e)
            {
                notDate = true;
                MessageBox.Show(e.Message);
            }
        }
    }
}
