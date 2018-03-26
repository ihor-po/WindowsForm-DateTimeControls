using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678_8
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Стоимость горючего
        /// </summary>
        double[] GasCost = { 30.95, 31.95, 32.95, 28.99, 29.99 };
        /// <summary>
        /// Таймер для работы со временем
        /// </summary>
        Timer timer;
        /// <summary>
        /// таймер для отсчета времени появления сообщения
        /// </summary>
        Timer coldown;
        /// <summary>
        /// Начало рабочего дня
        /// </summary>
        DateTime StartShift;
        /// <summary>
        /// Конец рабочего дня
        /// </summary>
        DateTime EndShift;

        int Seconds { get; set; }
        /// <summary>
        /// Общее колличество клиентов
        /// </summary>
        int Clients { get; set; }
        /// <summary>
        /// Общая сумма выручки за смену
        /// </summary>
        double DayTotal { get; set; }

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
          
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer = pio_functions.CreateTimer();
            coldown = pio_functions.CreateTimer();

            StartShift = new DateTime();
            EndShift = new DateTime();

            Seconds = 10;
            Clients = 0;
            DayTotal = 0.00;

            timer.Tick += Timer_Tick;
            timer.Start();

            coldown.Tick += Coldown_Tick;

            ClearData();
            DisableMainForm();

            bStart.Enabled = true;
            bStart.Click += BStart_Click;

            ggcb_gasoline.SelectedIndexChanged += Ggcb_gasoline_SelectedIndexChanged;

            gg_quantityTB.TextChanged += Gg_quantityTB_TextChanged;
            gg_quantityTB.KeyPress += Gg_quantityTB_KeyPress;
            gg_quantityTB.KeyUp += Gg_quantityTB_KeyUp;

            gg_gc_quantityRB.CheckedChanged += Gg_gc_quantityRB_CheckedChanged;

            gg_gc_sumRB.CheckedChanged += Gg_gc_sumRB_CheckedChanged;

            gg_sumTB.KeyUp += Gg_sumTB_KeyUp;
            gg_sumTB.KeyPress += Gg_sumTB_KeyPress;
            gg_sumTB.TextChanged += Gg_sumTB_TextChanged;

            mcg_HotDogCB.CheckedChanged += Mcg_HotDogCB_CheckedChanged;

            mcg_HotDogQuant.KeyPress += Mcg_HotDogQuant_KeyPress;
            mcg_HotDogQuant.KeyUp += Mcg_HotDogQuant_KeyUp;
            mcg_HotDogQuant.TextChanged += Mcg_HotDogQuant_TextChanged;

            mcg_SandweechCB.CheckedChanged += Mcg_SandweechCB_CheckedChanged;

            mcg_SandweechQuant.KeyPress += Mcg_HotDogQuant_KeyPress;
            mcg_SandweechQuant.KeyUp += Mcg_SandweechQuant_KeyUp;
            mcg_SandweechQuant.TextChanged += Mcg_HotDogQuant_TextChanged;

            mcg_FreetCB.CheckedChanged += Mcg_FreetCB_CheckedChanged;

            mcg_FreetQuant.KeyPress += Mcg_HotDogQuant_KeyPress;
            mcg_FreetQuant.KeyUp += Mcg_FreetQuant_KeyUp;
            mcg_FreetQuant.TextChanged += Mcg_HotDogQuant_TextChanged;

            mcg_CocaCB.CheckedChanged += Mcg_CocaCB_CheckedChanged;

            mcg_CocaQuant.KeyPress += Mcg_HotDogQuant_KeyPress;
            mcg_CocaQuant.KeyUp += Mcg_CocaQuant_KeyUp;
            mcg_CocaQuant.TextChanged += Mcg_HotDogQuant_TextChanged;

            mcg_CoffeCB.CheckedChanged += Mcg_CoffeCB_CheckedChanged;

            mcg_CoffeQuant.KeyPress += Mcg_HotDogQuant_KeyPress;
            mcg_CoffeQuant.KeyUp += Mcg_CoffeQuant_KeyUp;
            mcg_CoffeQuant.TextChanged += Mcg_HotDogQuant_TextChanged;

            bToPay.Click += BToPay_Click;
            bStop.Click += BStop_Click;

            this.FormClosing += MainForm_FormClosing;
        }

        private void BStop_Click(object sender, EventArgs e)
        {
            ClearData();
            DisableMainForm();
            EndShift = DateTime.Now;
            this.Close();
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EndShift.ToString() == "01.01.01 00:00:00")
            {
                EndShift = DateTime.Now;
            }

            if (StartShift.ToString() == "01.01.01 00:00:00")
            {
                StartShift = DateTime.Now;
            }

            if (Seconds != 0)
            {
                coldown.Stop();
            }

            string tmp = EndShift.Subtract(StartShift).ToString(@"hh\:mm\:ss");
            MessageBox.Show(
                $"Всего обслуженно клиентов: {Clients}.\rВыручка за смену: {DayTotal}.\rСмена длилась {tmp}",
                "BestOil",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        /// <summary>
        /// Обработка нажатия кнорки к оплате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BToPay_Click(object sender, EventArgs e)
        {
            double res = 0;
            
            if (gg_gc_quantityRB.Checked == true)
            {
                res += Convert.ToDouble(gg_gResultLabel.Text);
            }
            else
            {
                res += Convert.ToDouble(gg_sumTB.Text);
            }

            res += Convert.ToDouble(mcg_rg_resultLabel.Text);

            if (res != 0)
            {
                gbt_TotalLabel.Text = res.ToString();

                if (Seconds == 10)
                {
                    coldown.Start();
                }
            }
            else
            {

                MessageBox.Show(
                        "Вы не выбрали ни одиного товара",
                        "BestOil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                ClearData();
            }
        }

        /// <summary>
        /// Таймер обратного отсчета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coldown_Tick(object sender, EventArgs e)
        {
            DialogResult resDialog;
            double res = 0;
            Seconds--;
            if (Seconds == 0)
            {
                coldown.Stop();
                Seconds = 10;
                resDialog = MessageBox.Show(
                    "Завершить работу с клиентом?",
                    "BestOil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (resDialog == DialogResult.Yes)
                {
                    Clients++;

                    res = Convert.ToDouble(gbt_TotalLabel.Text);

                    DayTotal += res;

                    ClearData();
                }
                else
                {
                    Seconds = 9;
                    coldown.Start();
                }
            }
        }

        /// <summary>
        /// Обработка собития поднятия клавиш вверх для поля колличество Кофе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_CoffeQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (mcg_CoffeQuant.Text.Length == 0)
            {
                mcg_CoffeQuant.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 1 шт 
            if (e.KeyCode == Keys.Up)
            {
                if (mcg_CoffeQuant.Text != "")
                {
                    mcg_CoffeQuant.Text = (Convert.ToInt16(mcg_CoffeQuant.Text) + 1).ToString();
                }
                else
                {
                    mcg_CoffeQuant.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 1 шт
            if (e.KeyCode == Keys.Down)
            {
                if (mcg_CoffeQuant.Text != "" && Convert.ToDouble(mcg_CoffeQuant.Text) > 0)
                {
                    mcg_CoffeQuant.Text = (Convert.ToDouble(mcg_CoffeQuant.Text) - 1).ToString();
                }
                else
                {
                    mcg_CoffeQuant.Text = "0";
                }
            }
        }

        /// <summary>
        /// Обработка события изменения состояния чек бокса Кофе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_CoffeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mcg_CoffeCB.Checked == true)
            {
                mcg_CoffeQuant.Text = "1";
                mcg_CoffeQuant.Enabled = true;
                mcg_CoffeQuant.Focus();
            }
            else
            {
                mcg_CoffeQuant.Text = "0";
                mcg_CoffeQuant.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка события поднятия клавиш в поле Кока Кола колличество
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_CocaQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (mcg_CocaQuant.Text.Length == 0)
            {
                mcg_CocaQuant.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 1 шт 
            if (e.KeyCode == Keys.Up)
            {
                if (mcg_CocaQuant.Text != "")
                {
                    mcg_CocaQuant.Text = (Convert.ToInt16(mcg_CocaQuant.Text) + 1).ToString();
                }
                else
                {
                    mcg_CocaQuant.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 1 шт
            if (e.KeyCode == Keys.Down)
            {
                if (mcg_CocaQuant.Text != "" && Convert.ToDouble(mcg_CocaQuant.Text) > 0)
                {
                    mcg_CocaQuant.Text = (Convert.ToDouble(mcg_CocaQuant.Text) - 1).ToString();
                }
                else
                {
                    mcg_CocaQuant.Text = "0";
                }
            }
        }

        /// <summary>
        /// Обработка события изменения состояния чеек-бокса Кока Кола 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_CocaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mcg_CocaCB.Checked == true)
            {
                mcg_CocaQuant.Text = "1";
                mcg_CocaQuant.Enabled = true;
                mcg_CocaQuant.Focus();
            }
            else
            {
                mcg_CocaQuant.Text = "0";
                mcg_CocaQuant.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка события поднятия клавиш в поле Фри колличество
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_FreetQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (mcg_FreetQuant.Text.Length == 0)
            {
                mcg_FreetQuant.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 1 шт 
            if (e.KeyCode == Keys.Up)
            {
                if (mcg_FreetQuant.Text != "")
                {
                    mcg_FreetQuant.Text = (Convert.ToInt16(mcg_FreetQuant.Text) + 1).ToString();
                }
                else
                {
                    mcg_FreetQuant.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 1 шт
            if (e.KeyCode == Keys.Down)
            {
                if (mcg_FreetQuant.Text != "" && Convert.ToDouble(mcg_FreetQuant.Text) > 0)
                {
                    mcg_FreetQuant.Text = (Convert.ToDouble(mcg_FreetQuant.Text) - 1).ToString();
                }
                else
                {
                    mcg_FreetQuant.Text = "0";
                }
            }
        }

        /// <summary>
        /// Обработка события изменения состояния чекбокса Фри
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_FreetCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mcg_FreetCB.Checked == true)
            {
                mcg_FreetQuant.Text = "1";
                mcg_FreetQuant.Enabled = true;
                mcg_FreetQuant.Focus();
            }
            else
            {
                mcg_FreetQuant.Text = "0";
                mcg_FreetQuant.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка собития поднятия клавиши в поле гамбургер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_SandweechQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (mcg_SandweechQuant.Text.Length == 0)
            {
                mcg_SandweechQuant.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 1 шт 
            if (e.KeyCode == Keys.Up)
            {
                if (mcg_SandweechQuant.Text != "")
                {
                    mcg_SandweechQuant.Text = (Convert.ToInt16(mcg_SandweechQuant.Text) + 1).ToString();
                }
                else
                {
                    mcg_SandweechQuant.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 1 шт
            if (e.KeyCode == Keys.Down)
            {
                if (mcg_SandweechQuant.Text != "" && Convert.ToDouble(mcg_SandweechQuant.Text) > 0)
                {
                    mcg_SandweechQuant.Text = (Convert.ToDouble(mcg_SandweechQuant.Text) - 1).ToString();
                }
                else
                {
                    mcg_SandweechQuant.Text = "0";
                }
            }
        }

        /// <summary>
        /// Обработка собития выбора чекбокса гамбургер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_SandweechCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mcg_SandweechCB.Checked == true)
            {
                mcg_SandweechQuant.Text = "1";
                mcg_SandweechQuant.Enabled = true;
                mcg_SandweechQuant.Focus();
            }
            else
            {
                mcg_SandweechQuant.Text = "0";
                mcg_SandweechQuant.Enabled = false;
            }
        }
        
        /// <summary>
        /// Обработка изменения значения в поле колличество хот догов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_HotDogQuant_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 0)
            {
                pio_functions.CalcMinimarketItems(mc_group);
            }
           
        }

        /// <summary>
        /// Обработка собития поднятия клавиши вверх
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_HotDogQuant_KeyUp(object sender, KeyEventArgs e)
        {
            if (mcg_HotDogQuant.Text.Length == 0)
            {
                mcg_HotDogQuant.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 1 шт 
            if (e.KeyCode == Keys.Up)
            {
                if (mcg_HotDogQuant.Text != "")
                {
                    mcg_HotDogQuant.Text = (Convert.ToInt16(mcg_HotDogQuant.Text) + 1).ToString();
                }
                else
                {
                    mcg_HotDogQuant.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 1 шт
            if (e.KeyCode == Keys.Down)
            {
                if (mcg_HotDogQuant.Text != "" && Convert.ToDouble(mcg_HotDogQuant.Text) > 0)
                {
                    mcg_HotDogQuant.Text = (Convert.ToDouble(mcg_HotDogQuant.Text) - 1).ToString();
                }
                else
                {
                    mcg_HotDogQuant.Text = "0";
                }
            }
        }

        /// <summary>
        /// Обработка собития нажатия клавиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_HotDogQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if ((Int16)key != 8)
            {
                //Для проверки ввода только цифр

                if (!Char.IsDigit(key))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Обработка собития отмечания чекбокса Хот дог
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mcg_HotDogCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mcg_HotDogCB.Checked == true)
            {
                mcg_HotDogQuant.Text = "1";
                mcg_HotDogQuant.Enabled = true;
                mcg_HotDogQuant.Focus();
            }
            else
            {
                mcg_HotDogQuant.Text = "0";
                mcg_HotDogQuant.Enabled =false;
            }
        }

        private void Gg_sumTB_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Text.Length > 0 && tb.Text[tb.Text.Length - 1] != ',')
            {
                pio_functions.CalculateingGasolineCost(GasolineGroup);
            }
        }

        /// <summary>
        /// Обработка нажатия клавиш в поле сумма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_sumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if ((Int16)key != 8)
            {
                //Для проверки ввода только цифр

                if (!Char.IsDigit(key))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Обработка события поднятия клавиши в поле сумма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_sumTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (gg_sumTB.Text.Length == 0)
            {
                gg_gResultLabel.Text = "0";
            }

            // При нажатии на кнопку вверх добавляем по 10 литру 
            if (e.KeyCode == Keys.Up)
            {
                if (gg_sumTB.Text != "")
                {
                    gg_sumTB.Text = (Convert.ToInt16(gg_sumTB.Text) + 10).ToString();
                }
                else
                {
                    gg_sumTB.Text = "0";
                }
            }
            // При нажатии на кнопку вниз уменьшаем по 10 гривне
            if (e.KeyCode == Keys.Down)
            {
                if (gg_sumTB.Text != "" && Convert.ToDouble(gg_sumTB.Text) > 0)
                {
                    gg_sumTB.Text = (Convert.ToDouble(gg_sumTB.Text) - 10).ToString();
                }
                else
                {
                    gg_sumTB.Text = "0";
                }
            }
        }

        /// <summary>
        /// Изменение значение радиокнопки сумма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_gc_sumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (gg_gc_sumRB.Checked == true)
            {
                gg_gResult.Text = "К выдаче, л";
                gg_sumTB.Text = "0";
                gg_sumTB.Enabled = true;
                gg_sumTB.Focus();
            }
            else
            {
                gg_sumTB.Text = "0";
                gg_sumTB.Enabled = false;
            }
        }

        /// <summary>
        /// Изменение значение радиокнопки колличество
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_gc_quantityRB_CheckedChanged(object sender, EventArgs e)
        {
            if (gg_gc_quantityRB.Checked == true)
            {
                gg_gResult.Text = "К оплате, грн";
                gg_quantityTB.Text = "0";
                gg_quantityTB.Enabled = true;
                gg_quantityTB.Focus();
            }
            else
            {
                gg_quantityTB.Text = "0";
                gg_quantityTB.Enabled = false;
            }
        }

        /// <summary>
        /// Обработка поднятия кнопки в поле колличетво
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_quantityTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (gg_quantityTB.Text.Length == 0)
            {
                gg_gResultLabel.Text = "0,00";
            }

            // При нажатии на кнопку вверх добавляем по 0,1 литру 
            if (e.KeyCode == Keys.Up)
            {
                if (gg_quantityTB.Text != "")
                {
                    gg_quantityTB.Text = (Convert.ToDouble(gg_quantityTB.Text) + 0.1).ToString();
                }
                else
                {
                    gg_quantityTB.Text = "0,00";
                }
            }

            // При нажатии на кнопку вниз уменьшаем по 0,1 литру
            if (e.KeyCode == Keys.Down)
            {
                if (gg_quantityTB.Text != "" && Convert.ToDouble(gg_quantityTB.Text) > 0)
                {
                    gg_quantityTB.Text = (Convert.ToDouble(gg_quantityTB.Text) - 0.1).ToString();
                }
                else
                {
                    gg_quantityTB.Text = "0,00";
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопок в поле колличество
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_quantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if ((Int16)key != 8 && key != ',')
            {
                //Для проверки ввода только цифр

                if (!Char.IsDigit(key))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Обработка собитя в поле колличество при изменении текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gg_quantityTB_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            
            if (tb.Text.Length > 0 && tb.Text[tb.Text.Length - 1] != ',')
            {
                pio_functions.CalculateingGasolineCost(GasolineGroup);
            }
        }

        /// <summary>
        /// Собыите изменения выбранного топлива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ggcb_gasoline_SelectedIndexChanged(object sender, EventArgs e)
        {

            gg_GasCostTB.Text = GasCost[ggcb_gasoline.SelectedIndex].ToString();

            pio_functions.CalculateingGasolineCost(GasolineGroup);

        }

        /// <summary>
        /// Обработка жатия кнопки "Начать смену"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BStart_Click(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            bStop.Enabled = true;
            bToPay.Enabled = true;

            EnableMainElements();
            ClearData();

            StartShift = DateTime.Now;
            ggcb_gasoline.Focus();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tb_DateTime.Text = "   " + DateTime.Now.ToLocalTime().ToLongDateString() + "   " + DateTime.Now.ToLocalTime().ToLongTimeString();
        }

        /// <summary>
        /// Все елементы для работы становятся неактивными
        /// </summary>
        private void DisableMainForm()
        {
            foreach(var item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (var subitem in ((GroupBox)item).Controls)
                    {
                        if (subitem is ComboBox)
                        {
                            if (((ComboBox)subitem).Enabled)
                            {
                                ((ComboBox)subitem).Enabled = false;
                            }
                        }

                        if (subitem is TextBox)
                        {
                            if (((TextBox)subitem).Enabled)
                            {
                                ((TextBox)subitem).Enabled = false;
                            }
                        }
                        if (subitem is CheckBox)
                        {
                            if (((CheckBox)subitem).Enabled)
                            {
                                ((CheckBox)subitem).Enabled = false;
                            }
                        }
                        if (subitem is RadioButton)
                        {
                            if (((RadioButton)subitem).Enabled)
                            {
                                ((RadioButton)subitem).Enabled = false;
                            }
                        }
                        if (subitem is GroupBox)
                        {
                            foreach (var _subitem in ((GroupBox)subitem).Controls)
                            {
                                if (_subitem is RadioButton)
                                {
                                    if (((RadioButton)_subitem).Enabled)
                                    {
                                        ((RadioButton)_subitem).Enabled = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Активация начальных элементов
        /// </summary>
        private void EnableMainElements()
        {
            ggcb_gasoline.Enabled = true;

            foreach (RadioButton rb in gg_choose_radio.Controls)
            {
                rb.Enabled = true;
            }

            gg_quantityTB.Enabled = true;

            foreach (var item in mc_group.Controls)
            {
                if (item is CheckBox)
                {
                    ((CheckBox)item).Enabled = true;
                }
                
            }
        }

        /// <summary>
        /// Подготовка формы к работе с новым клиентом
        /// </summary>
        private void ClearData()
        {
            ggcb_gasoline.SelectedIndex = 0 ;
            gg_GasCostTB.Text = GasCost[ggcb_gasoline.SelectedIndex].ToString();
            gg_gc_quantityRB.Checked = true;
            gg_quantityTB.Text = "0";
            gg_sumTB.Text = "0";
            gg_sumTB.Enabled = false;
            gg_gResultLabel.Text = "0,00";

            foreach (object cb in mc_group.Controls)
            {
                if (cb is CheckBox)
                {
                    ((CheckBox)cb).Checked = false;
                }
            }

            mcg_rg_resultLabel.Text = "0,00";

            gbt_TotalLabel.Text = "0,00";

            tb_DayTotal.Text = $"Количество клиентов: {Clients}; Общий доход: {DayTotal}";
        }
    }
}
