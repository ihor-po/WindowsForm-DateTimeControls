using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2_task678_8
{
    public class pio_functions
    {
        public static Timer CreateTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;

            return timer;
        }

        /// <summary>
        /// Вычисляет стоимость горючего выбранного пользователем
        /// </summary>
        /// <param name="gb"></param>
        public static void CalculateingGasolineCost(GroupBox gb)
        {
            double quantity = 0;
            double cost = 0;
            int sum = 0;

            GroupBox gbResult = new GroupBox();
            GroupBox gRadioButtons = new GroupBox();
            Label resLabel = new Label();

            foreach (var item in gb.Controls)
            {
                if (item is TextBox && ((TextBox)item).Name == "gg_quantityTB")
                {
                    quantity = Convert.ToDouble(((TextBox)item).Text);
                }

                if (item is TextBox && ((TextBox)item).Name == "gg_GasCostTB")
                {
                    cost = Convert.ToDouble(((TextBox)item).Text);
                }

                if (item is TextBox && ((TextBox)item).Name == "gg_sumTB")
                {
                    sum = Convert.ToInt16(((TextBox)item).Text);
                }

                if (item is GroupBox && ((GroupBox)item).Name == "gg_choose_radio")
                {
                    gRadioButtons = (GroupBox)item;
                }
                if (item is GroupBox && ((GroupBox)item).Name == "gg_gResult")
                {
                    gbResult = (GroupBox)item;
                }
            }

           RadioButton cRB = gRadioButtons.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            resLabel = gbResult.Controls.OfType<Label>().First<Label>();

            switch (cRB.Name)
            {
                case "gg_gc_quantityRB":
                    resLabel.Text = Math.Round(Convert.ToDouble(quantity * cost), 2).ToString();
                    break;
                case "gg_gc_sumRB":
                    resLabel.Text = Math.Round(sum / cost, 2).ToString();
                    break;
            }
        }

        public static void CalcMinimarketItems(GroupBox gb)
        {
            Label ResLabel = new Label();
            List<TextBox> tbs = gb.Controls.OfType<TextBox>().ToList();
            string name = "";

            double ItemQuantity = 0;
            double ItemCost = 0;
            double Res = 0.00;

            foreach (var item in gb.Controls)
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked == true)
                    {
                        name = ((CheckBox)item).Name;

                        switch (name)
                        {
                            case "mcg_HotDogCB":
                                foreach (TextBox tbItem in tbs)
                                {
                                    if (tbItem.Name == "mcg_HotDogQuant")
                                    {
                                        ItemQuantity = Convert.ToDouble(tbItem.Text);
                                    }
                                    if (tbItem.Name == "mcg_HotDogPrice")
                                    {
                                        ItemCost = Convert.ToDouble(tbItem.Text);
                                    }
                                }
                                break;
                            case "mcg_SandweechCB":
                                foreach (TextBox tbItem in tbs)
                                {
                                    if (tbItem.Name == "mcg_SandweechQuant")
                                    {
                                        ItemQuantity = Convert.ToDouble(tbItem.Text);
                                    }
                                    if (tbItem.Name == "mcg_SandweechPrice")
                                    {
                                        ItemCost = Convert.ToDouble(tbItem.Text);
                                    }
                                }
                                break;
                            case "mcg_FreetCB":
                                foreach (TextBox tbItem in tbs)
                                {
                                    if (tbItem.Name == "mcg_FreetQuant")
                                    {
                                        ItemQuantity = Convert.ToDouble(tbItem.Text);
                                    }
                                    if (tbItem.Name == "mcg_FreetPrice")
                                    {
                                        ItemCost = Convert.ToDouble(tbItem.Text);
                                    }
                                }
                                break;
                            case "mcg_CocaCB":
                                foreach (TextBox tbItem in tbs)
                                {
                                    if (tbItem.Name == "mcg_CocaQuant")
                                    {
                                        ItemQuantity = Convert.ToDouble(tbItem.Text);
                                    }
                                    if (tbItem.Name == "mcg_CocaPrice")
                                    {
                                        ItemCost = Convert.ToDouble(tbItem.Text);
                                    }
                                }
                                break;
                            case "mcg_CoffeCB":
                                foreach (TextBox tbItem in tbs)
                                {
                                    if (tbItem.Name == "mcg_CoffeQuant")
                                    {
                                        ItemQuantity = Convert.ToDouble(tbItem.Text);
                                    }
                                    if (tbItem.Name == "mcg_CoffePrice")
                                    {
                                        ItemCost = Convert.ToDouble(tbItem.Text);
                                    }
                                }
                                break;
                        }
                        Res += ItemQuantity * ItemCost;
                    }
                }
                if (item is GroupBox)
                {
                    ResLabel = ((GroupBox)item).Controls.OfType<Label>().First<Label>();
                }
            }
            ResLabel.Text = Math.Round(Res, 2).ToString();
        }
    }
}
