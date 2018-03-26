namespace dz2_task678_8
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GasolineGroup = new System.Windows.Forms.GroupBox();
            this.gg_gResult = new System.Windows.Forms.GroupBox();
            this.gg_gResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gg_sumTB = new System.Windows.Forms.TextBox();
            this.gg_quantityTB = new System.Windows.Forms.TextBox();
            this.gg_choose_radio = new System.Windows.Forms.GroupBox();
            this.gg_gc_sumRB = new System.Windows.Forms.RadioButton();
            this.gg_gc_quantityRB = new System.Windows.Forms.RadioButton();
            this.gg_GasCostTB = new System.Windows.Forms.TextBox();
            this.ggl_price = new System.Windows.Forms.Label();
            this.ggcb_gasoline = new System.Windows.Forms.ComboBox();
            this.ggl_gasoline = new System.Windows.Forms.Label();
            this.mc_group = new System.Windows.Forms.GroupBox();
            this.mcg_CoffeQuant = new System.Windows.Forms.TextBox();
            this.mcg_CoffePrice = new System.Windows.Forms.TextBox();
            this.mcg_CoffeCB = new System.Windows.Forms.CheckBox();
            this.mcg_ResultGroup = new System.Windows.Forms.GroupBox();
            this.mcg_rg_resultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mcg_CocaQuant = new System.Windows.Forms.TextBox();
            this.mcg_CocaPrice = new System.Windows.Forms.TextBox();
            this.mcg_FreetQuant = new System.Windows.Forms.TextBox();
            this.mcg_FreetPrice = new System.Windows.Forms.TextBox();
            this.mcg_SandweechQuant = new System.Windows.Forms.TextBox();
            this.mcg_SandweechPrice = new System.Windows.Forms.TextBox();
            this.mcg_HotDogQuant = new System.Windows.Forms.TextBox();
            this.mcg_HotDogPrice = new System.Windows.Forms.TextBox();
            this.mcg_CocaCB = new System.Windows.Forms.CheckBox();
            this.mcg_FreetCB = new System.Windows.Forms.CheckBox();
            this.mcg_SandweechCB = new System.Windows.Forms.CheckBox();
            this.mcg_HotDogCB = new System.Windows.Forms.CheckBox();
            this.bToPay = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tb_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tb_DayTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.gb_total = new System.Windows.Forms.GroupBox();
            this.gbt_TotalLabel = new System.Windows.Forms.Label();
            this.GasolineGroup.SuspendLayout();
            this.gg_gResult.SuspendLayout();
            this.gg_choose_radio.SuspendLayout();
            this.mc_group.SuspendLayout();
            this.mcg_ResultGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gb_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // GasolineGroup
            // 
            this.GasolineGroup.Controls.Add(this.gg_gResult);
            this.GasolineGroup.Controls.Add(this.label2);
            this.GasolineGroup.Controls.Add(this.label1);
            this.GasolineGroup.Controls.Add(this.gg_sumTB);
            this.GasolineGroup.Controls.Add(this.gg_quantityTB);
            this.GasolineGroup.Controls.Add(this.gg_choose_radio);
            this.GasolineGroup.Controls.Add(this.gg_GasCostTB);
            this.GasolineGroup.Controls.Add(this.ggl_price);
            this.GasolineGroup.Controls.Add(this.ggcb_gasoline);
            this.GasolineGroup.Controls.Add(this.ggl_gasoline);
            this.GasolineGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GasolineGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasolineGroup.ForeColor = System.Drawing.Color.DimGray;
            this.GasolineGroup.Location = new System.Drawing.Point(12, 12);
            this.GasolineGroup.Name = "GasolineGroup";
            this.GasolineGroup.Size = new System.Drawing.Size(278, 361);
            this.GasolineGroup.TabIndex = 0;
            this.GasolineGroup.TabStop = false;
            this.GasolineGroup.Text = "Автозаправка";
            // 
            // gg_gResult
            // 
            this.gg_gResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gg_gResult.Controls.Add(this.gg_gResultLabel);
            this.gg_gResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_gResult.Location = new System.Drawing.Point(10, 247);
            this.gg_gResult.Name = "gg_gResult";
            this.gg_gResult.Size = new System.Drawing.Size(256, 100);
            this.gg_gResult.TabIndex = 9;
            this.gg_gResult.TabStop = false;
            this.gg_gResult.Text = "К оплате, грн";
            // 
            // gg_gResultLabel
            // 
            this.gg_gResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gg_gResultLabel.AutoSize = true;
            this.gg_gResultLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_gResultLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.gg_gResultLabel.Location = new System.Drawing.Point(69, 26);
            this.gg_gResultLabel.Name = "gg_gResultLabel";
            this.gg_gResultLabel.Size = new System.Drawing.Size(133, 59);
            this.gg_gResultLabel.TabIndex = 0;
            this.gg_gResultLabel.Text = "00,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(242, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "грн";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(242, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "л";
            // 
            // gg_sumTB
            // 
            this.gg_sumTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gg_sumTB.Enabled = false;
            this.gg_sumTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_sumTB.Location = new System.Drawing.Point(170, 198);
            this.gg_sumTB.Name = "gg_sumTB";
            this.gg_sumTB.Size = new System.Drawing.Size(70, 20);
            this.gg_sumTB.TabIndex = 6;
            this.gg_sumTB.Text = "0";
            this.gg_sumTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gg_quantityTB
            // 
            this.gg_quantityTB.BackColor = System.Drawing.SystemColors.Window;
            this.gg_quantityTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gg_quantityTB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_quantityTB.Location = new System.Drawing.Point(170, 166);
            this.gg_quantityTB.Name = "gg_quantityTB";
            this.gg_quantityTB.Size = new System.Drawing.Size(69, 20);
            this.gg_quantityTB.TabIndex = 5;
            this.gg_quantityTB.Text = "0";
            this.gg_quantityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gg_choose_radio
            // 
            this.gg_choose_radio.Controls.Add(this.gg_gc_sumRB);
            this.gg_choose_radio.Controls.Add(this.gg_gc_quantityRB);
            this.gg_choose_radio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gg_choose_radio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_choose_radio.Location = new System.Drawing.Point(10, 138);
            this.gg_choose_radio.Name = "gg_choose_radio";
            this.gg_choose_radio.Size = new System.Drawing.Size(149, 100);
            this.gg_choose_radio.TabIndex = 4;
            this.gg_choose_radio.TabStop = false;
            // 
            // gg_gc_sumRB
            // 
            this.gg_gc_sumRB.AutoSize = true;
            this.gg_gc_sumRB.ForeColor = System.Drawing.Color.Black;
            this.gg_gc_sumRB.Location = new System.Drawing.Point(10, 58);
            this.gg_gc_sumRB.Name = "gg_gc_sumRB";
            this.gg_gc_sumRB.Size = new System.Drawing.Size(73, 23);
            this.gg_gc_sumRB.TabIndex = 4;
            this.gg_gc_sumRB.Text = "Сумма";
            this.gg_gc_sumRB.UseVisualStyleBackColor = true;
            // 
            // gg_gc_quantityRB
            // 
            this.gg_gc_quantityRB.AutoSize = true;
            this.gg_gc_quantityRB.Checked = true;
            this.gg_gc_quantityRB.ForeColor = System.Drawing.Color.Black;
            this.gg_gc_quantityRB.Location = new System.Drawing.Point(10, 26);
            this.gg_gc_quantityRB.Name = "gg_gc_quantityRB";
            this.gg_gc_quantityRB.Size = new System.Drawing.Size(114, 23);
            this.gg_gc_quantityRB.TabIndex = 3;
            this.gg_gc_quantityRB.TabStop = true;
            this.gg_gc_quantityRB.Text = "Колличество";
            this.gg_gc_quantityRB.UseVisualStyleBackColor = true;
            // 
            // gg_GasCostTB
            // 
            this.gg_GasCostTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gg_GasCostTB.Enabled = false;
            this.gg_GasCostTB.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg_GasCostTB.Location = new System.Drawing.Point(111, 92);
            this.gg_GasCostTB.Name = "gg_GasCostTB";
            this.gg_GasCostTB.Size = new System.Drawing.Size(155, 30);
            this.gg_GasCostTB.TabIndex = 2;
            // 
            // ggl_price
            // 
            this.ggl_price.AutoSize = true;
            this.ggl_price.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ggl_price.ForeColor = System.Drawing.Color.Black;
            this.ggl_price.Location = new System.Drawing.Point(12, 96);
            this.ggl_price.Name = "ggl_price";
            this.ggl_price.Size = new System.Drawing.Size(86, 23);
            this.ggl_price.TabIndex = 2;
            this.ggl_price.Text = "Цена, грн";
            // 
            // ggcb_gasoline
            // 
            this.ggcb_gasoline.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ggcb_gasoline.FormattingEnabled = true;
            this.ggcb_gasoline.Items.AddRange(new object[] {
            "А-92",
            "А-95",
            "А-95 Премиум",
            "ДТ",
            "ДТ Премиум"});
            this.ggcb_gasoline.Location = new System.Drawing.Point(111, 43);
            this.ggcb_gasoline.Name = "ggcb_gasoline";
            this.ggcb_gasoline.Size = new System.Drawing.Size(155, 31);
            this.ggcb_gasoline.Sorted = true;
            this.ggcb_gasoline.TabIndex = 1;
            // 
            // ggl_gasoline
            // 
            this.ggl_gasoline.AutoSize = true;
            this.ggl_gasoline.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ggl_gasoline.ForeColor = System.Drawing.Color.Black;
            this.ggl_gasoline.Location = new System.Drawing.Point(31, 48);
            this.ggl_gasoline.Name = "ggl_gasoline";
            this.ggl_gasoline.Size = new System.Drawing.Size(67, 23);
            this.ggl_gasoline.TabIndex = 0;
            this.ggl_gasoline.Text = "Бензин";
            // 
            // mc_group
            // 
            this.mc_group.Controls.Add(this.mcg_CoffeQuant);
            this.mc_group.Controls.Add(this.mcg_CoffePrice);
            this.mc_group.Controls.Add(this.mcg_CoffeCB);
            this.mc_group.Controls.Add(this.mcg_ResultGroup);
            this.mc_group.Controls.Add(this.label4);
            this.mc_group.Controls.Add(this.label3);
            this.mc_group.Controls.Add(this.mcg_CocaQuant);
            this.mc_group.Controls.Add(this.mcg_CocaPrice);
            this.mc_group.Controls.Add(this.mcg_FreetQuant);
            this.mc_group.Controls.Add(this.mcg_FreetPrice);
            this.mc_group.Controls.Add(this.mcg_SandweechQuant);
            this.mc_group.Controls.Add(this.mcg_SandweechPrice);
            this.mc_group.Controls.Add(this.mcg_HotDogQuant);
            this.mc_group.Controls.Add(this.mcg_HotDogPrice);
            this.mc_group.Controls.Add(this.mcg_CocaCB);
            this.mc_group.Controls.Add(this.mcg_FreetCB);
            this.mc_group.Controls.Add(this.mcg_SandweechCB);
            this.mc_group.Controls.Add(this.mcg_HotDogCB);
            this.mc_group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mc_group.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mc_group.ForeColor = System.Drawing.Color.DimGray;
            this.mc_group.Location = new System.Drawing.Point(311, 12);
            this.mc_group.Name = "mc_group";
            this.mc_group.Size = new System.Drawing.Size(278, 361);
            this.mc_group.TabIndex = 10;
            this.mc_group.TabStop = false;
            this.mc_group.Text = "Мини-кафе";
            // 
            // mcg_CoffeQuant
            // 
            this.mcg_CoffeQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_CoffeQuant.Enabled = false;
            this.mcg_CoffeQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_CoffeQuant.Location = new System.Drawing.Point(204, 212);
            this.mcg_CoffeQuant.Name = "mcg_CoffeQuant";
            this.mcg_CoffeQuant.Size = new System.Drawing.Size(62, 20);
            this.mcg_CoffeQuant.TabIndex = 16;
            this.mcg_CoffeQuant.Text = "0";
            this.mcg_CoffeQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_CoffePrice
            // 
            this.mcg_CoffePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_CoffePrice.Enabled = false;
            this.mcg_CoffePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_CoffePrice.Location = new System.Drawing.Point(127, 212);
            this.mcg_CoffePrice.Name = "mcg_CoffePrice";
            this.mcg_CoffePrice.Size = new System.Drawing.Size(62, 20);
            this.mcg_CoffePrice.TabIndex = 15;
            this.mcg_CoffePrice.Text = "15";
            this.mcg_CoffePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_CoffeCB
            // 
            this.mcg_CoffeCB.AutoSize = true;
            this.mcg_CoffeCB.Font = new System.Drawing.Font("Calibri", 14F);
            this.mcg_CoffeCB.ForeColor = System.Drawing.Color.Black;
            this.mcg_CoffeCB.Location = new System.Drawing.Point(7, 208);
            this.mcg_CoffeCB.Name = "mcg_CoffeCB";
            this.mcg_CoffeCB.Size = new System.Drawing.Size(70, 27);
            this.mcg_CoffeCB.TabIndex = 14;
            this.mcg_CoffeCB.Text = "Кофе";
            this.mcg_CoffeCB.UseVisualStyleBackColor = true;
            // 
            // mcg_ResultGroup
            // 
            this.mcg_ResultGroup.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mcg_ResultGroup.Controls.Add(this.mcg_rg_resultLabel);
            this.mcg_ResultGroup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_ResultGroup.Location = new System.Drawing.Point(9, 247);
            this.mcg_ResultGroup.Name = "mcg_ResultGroup";
            this.mcg_ResultGroup.Size = new System.Drawing.Size(256, 100);
            this.mcg_ResultGroup.TabIndex = 10;
            this.mcg_ResultGroup.TabStop = false;
            this.mcg_ResultGroup.Text = "К оплате, грн";
            // 
            // mcg_rg_resultLabel
            // 
            this.mcg_rg_resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcg_rg_resultLabel.AutoSize = true;
            this.mcg_rg_resultLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_rg_resultLabel.ForeColor = System.Drawing.Color.RosyBrown;
            this.mcg_rg_resultLabel.Location = new System.Drawing.Point(71, 25);
            this.mcg_rg_resultLabel.Name = "mcg_rg_resultLabel";
            this.mcg_rg_resultLabel.Size = new System.Drawing.Size(133, 59);
            this.mcg_rg_resultLabel.TabIndex = 0;
            this.mcg_rg_resultLabel.Text = "00,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(205, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Кол-во\r\n   шт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(134, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Цена,\r\n грн";
            // 
            // mcg_CocaQuant
            // 
            this.mcg_CocaQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_CocaQuant.Enabled = false;
            this.mcg_CocaQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_CocaQuant.Location = new System.Drawing.Point(204, 178);
            this.mcg_CocaQuant.Name = "mcg_CocaQuant";
            this.mcg_CocaQuant.Size = new System.Drawing.Size(62, 20);
            this.mcg_CocaQuant.TabIndex = 11;
            this.mcg_CocaQuant.Text = "0";
            this.mcg_CocaQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_CocaPrice
            // 
            this.mcg_CocaPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_CocaPrice.Enabled = false;
            this.mcg_CocaPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_CocaPrice.Location = new System.Drawing.Point(127, 178);
            this.mcg_CocaPrice.Name = "mcg_CocaPrice";
            this.mcg_CocaPrice.Size = new System.Drawing.Size(62, 20);
            this.mcg_CocaPrice.TabIndex = 10;
            this.mcg_CocaPrice.Text = "19,95";
            this.mcg_CocaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_FreetQuant
            // 
            this.mcg_FreetQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_FreetQuant.Enabled = false;
            this.mcg_FreetQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_FreetQuant.Location = new System.Drawing.Point(204, 141);
            this.mcg_FreetQuant.Name = "mcg_FreetQuant";
            this.mcg_FreetQuant.Size = new System.Drawing.Size(62, 20);
            this.mcg_FreetQuant.TabIndex = 9;
            this.mcg_FreetQuant.Text = "0";
            this.mcg_FreetQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_FreetPrice
            // 
            this.mcg_FreetPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_FreetPrice.Enabled = false;
            this.mcg_FreetPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_FreetPrice.Location = new System.Drawing.Point(127, 141);
            this.mcg_FreetPrice.Name = "mcg_FreetPrice";
            this.mcg_FreetPrice.Size = new System.Drawing.Size(62, 20);
            this.mcg_FreetPrice.TabIndex = 8;
            this.mcg_FreetPrice.Text = "24,95";
            this.mcg_FreetPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_SandweechQuant
            // 
            this.mcg_SandweechQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_SandweechQuant.Enabled = false;
            this.mcg_SandweechQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_SandweechQuant.Location = new System.Drawing.Point(204, 105);
            this.mcg_SandweechQuant.Name = "mcg_SandweechQuant";
            this.mcg_SandweechQuant.Size = new System.Drawing.Size(62, 20);
            this.mcg_SandweechQuant.TabIndex = 7;
            this.mcg_SandweechQuant.Text = "0";
            this.mcg_SandweechQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_SandweechPrice
            // 
            this.mcg_SandweechPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_SandweechPrice.Enabled = false;
            this.mcg_SandweechPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_SandweechPrice.Location = new System.Drawing.Point(127, 105);
            this.mcg_SandweechPrice.Name = "mcg_SandweechPrice";
            this.mcg_SandweechPrice.Size = new System.Drawing.Size(62, 20);
            this.mcg_SandweechPrice.TabIndex = 6;
            this.mcg_SandweechPrice.Text = "39,99";
            this.mcg_SandweechPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_HotDogQuant
            // 
            this.mcg_HotDogQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_HotDogQuant.Enabled = false;
            this.mcg_HotDogQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_HotDogQuant.Location = new System.Drawing.Point(204, 68);
            this.mcg_HotDogQuant.Name = "mcg_HotDogQuant";
            this.mcg_HotDogQuant.Size = new System.Drawing.Size(62, 20);
            this.mcg_HotDogQuant.TabIndex = 5;
            this.mcg_HotDogQuant.Text = "0";
            this.mcg_HotDogQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_HotDogPrice
            // 
            this.mcg_HotDogPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcg_HotDogPrice.Enabled = false;
            this.mcg_HotDogPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcg_HotDogPrice.Location = new System.Drawing.Point(127, 68);
            this.mcg_HotDogPrice.Name = "mcg_HotDogPrice";
            this.mcg_HotDogPrice.Size = new System.Drawing.Size(62, 20);
            this.mcg_HotDogPrice.TabIndex = 4;
            this.mcg_HotDogPrice.Text = "34,95";
            this.mcg_HotDogPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mcg_CocaCB
            // 
            this.mcg_CocaCB.AutoSize = true;
            this.mcg_CocaCB.Font = new System.Drawing.Font("Calibri", 14F);
            this.mcg_CocaCB.ForeColor = System.Drawing.Color.Black;
            this.mcg_CocaCB.Location = new System.Drawing.Point(7, 174);
            this.mcg_CocaCB.Name = "mcg_CocaCB";
            this.mcg_CocaCB.Size = new System.Drawing.Size(103, 27);
            this.mcg_CocaCB.TabIndex = 3;
            this.mcg_CocaCB.Text = "Coca-cola";
            this.mcg_CocaCB.UseVisualStyleBackColor = true;
            // 
            // mcg_FreetCB
            // 
            this.mcg_FreetCB.AutoSize = true;
            this.mcg_FreetCB.Font = new System.Drawing.Font("Calibri", 14F);
            this.mcg_FreetCB.ForeColor = System.Drawing.Color.Black;
            this.mcg_FreetCB.Location = new System.Drawing.Point(7, 140);
            this.mcg_FreetCB.Name = "mcg_FreetCB";
            this.mcg_FreetCB.Size = new System.Drawing.Size(62, 27);
            this.mcg_FreetCB.TabIndex = 2;
            this.mcg_FreetCB.Text = "Фри";
            this.mcg_FreetCB.UseVisualStyleBackColor = true;
            // 
            // mcg_SandweechCB
            // 
            this.mcg_SandweechCB.AutoSize = true;
            this.mcg_SandweechCB.Font = new System.Drawing.Font("Calibri", 14F);
            this.mcg_SandweechCB.ForeColor = System.Drawing.Color.Black;
            this.mcg_SandweechCB.Location = new System.Drawing.Point(7, 103);
            this.mcg_SandweechCB.Name = "mcg_SandweechCB";
            this.mcg_SandweechCB.Size = new System.Drawing.Size(113, 27);
            this.mcg_SandweechCB.TabIndex = 1;
            this.mcg_SandweechCB.Text = "Гамбургер";
            this.mcg_SandweechCB.UseVisualStyleBackColor = true;
            // 
            // mcg_HotDogCB
            // 
            this.mcg_HotDogCB.AutoSize = true;
            this.mcg_HotDogCB.Font = new System.Drawing.Font("Calibri", 14F);
            this.mcg_HotDogCB.ForeColor = System.Drawing.Color.Black;
            this.mcg_HotDogCB.Location = new System.Drawing.Point(8, 66);
            this.mcg_HotDogCB.Name = "mcg_HotDogCB";
            this.mcg_HotDogCB.Size = new System.Drawing.Size(90, 27);
            this.mcg_HotDogCB.TabIndex = 0;
            this.mcg_HotDogCB.Text = "Хот-дог";
            this.mcg_HotDogCB.UseVisualStyleBackColor = true;
            // 
            // bToPay
            // 
            this.bToPay.Enabled = false;
            this.bToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bToPay.Location = new System.Drawing.Point(425, 379);
            this.bToPay.Name = "bToPay";
            this.bToPay.Size = new System.Drawing.Size(164, 44);
            this.bToPay.TabIndex = 11;
            this.bToPay.Text = "К оплате";
            this.bToPay.UseVisualStyleBackColor = true;
            // 
            // bStart
            // 
            this.bStart.Enabled = false;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(425, 429);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(164, 44);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Начать смену";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStop.Location = new System.Drawing.Point(425, 479);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(164, 44);
            this.bStop.TabIndex = 13;
            this.bStop.Text = "Завершить смену";
            this.bStop.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_DateTime,
            this.tb_DayTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tb_DateTime
            // 
            this.tb_DateTime.Name = "tb_DateTime";
            this.tb_DateTime.Size = new System.Drawing.Size(118, 17);
            this.tb_DateTime.Text = "toolStripStatusLabel1";
            // 
            // tb_DayTotal
            // 
            this.tb_DayTotal.Name = "tb_DayTotal";
            this.tb_DayTotal.Size = new System.Drawing.Size(118, 17);
            this.tb_DayTotal.Text = "toolStripStatusLabel2";
            // 
            // gb_total
            // 
            this.gb_total.Controls.Add(this.gbt_TotalLabel);
            this.gb_total.Location = new System.Drawing.Point(12, 374);
            this.gb_total.Name = "gb_total";
            this.gb_total.Size = new System.Drawing.Size(407, 151);
            this.gb_total.TabIndex = 15;
            this.gb_total.TabStop = false;
            this.gb_total.Text = "Общая стоимость, грн";
            // 
            // gbt_TotalLabel
            // 
            this.gbt_TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbt_TotalLabel.AutoSize = true;
            this.gbt_TotalLabel.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbt_TotalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.gbt_TotalLabel.Location = new System.Drawing.Point(121, 42);
            this.gbt_TotalLabel.Name = "gbt_TotalLabel";
            this.gbt_TotalLabel.Size = new System.Drawing.Size(178, 78);
            this.gbt_TotalLabel.TabIndex = 1;
            this.gbt_TotalLabel.Text = "00,00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(600, 555);
            this.Controls.Add(this.gb_total);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bToPay);
            this.Controls.Add(this.mc_group);
            this.Controls.Add(this.GasolineGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"BestOil\" -  Заправь нутро!";
            this.GasolineGroup.ResumeLayout(false);
            this.GasolineGroup.PerformLayout();
            this.gg_gResult.ResumeLayout(false);
            this.gg_gResult.PerformLayout();
            this.gg_choose_radio.ResumeLayout(false);
            this.gg_choose_radio.PerformLayout();
            this.mc_group.ResumeLayout(false);
            this.mc_group.PerformLayout();
            this.mcg_ResultGroup.ResumeLayout(false);
            this.mcg_ResultGroup.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_total.ResumeLayout(false);
            this.gb_total.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GasolineGroup;
        private System.Windows.Forms.Label ggl_gasoline;
        private System.Windows.Forms.ComboBox ggcb_gasoline;
        private System.Windows.Forms.TextBox gg_GasCostTB;
        private System.Windows.Forms.Label ggl_price;
        private System.Windows.Forms.GroupBox gg_choose_radio;
        private System.Windows.Forms.RadioButton gg_gc_sumRB;
        private System.Windows.Forms.RadioButton gg_gc_quantityRB;
        private System.Windows.Forms.TextBox gg_sumTB;
        private System.Windows.Forms.TextBox gg_quantityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gg_gResult;
        private System.Windows.Forms.Label gg_gResultLabel;
        private System.Windows.Forms.GroupBox mc_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mcg_CocaQuant;
        private System.Windows.Forms.TextBox mcg_CocaPrice;
        private System.Windows.Forms.TextBox mcg_FreetQuant;
        private System.Windows.Forms.TextBox mcg_FreetPrice;
        private System.Windows.Forms.TextBox mcg_SandweechQuant;
        private System.Windows.Forms.TextBox mcg_SandweechPrice;
        private System.Windows.Forms.TextBox mcg_HotDogQuant;
        private System.Windows.Forms.TextBox mcg_HotDogPrice;
        private System.Windows.Forms.CheckBox mcg_CocaCB;
        private System.Windows.Forms.CheckBox mcg_FreetCB;
        private System.Windows.Forms.CheckBox mcg_SandweechCB;
        private System.Windows.Forms.CheckBox mcg_HotDogCB;
        private System.Windows.Forms.TextBox mcg_CoffeQuant;
        private System.Windows.Forms.TextBox mcg_CoffePrice;
        private System.Windows.Forms.CheckBox mcg_CoffeCB;
        private System.Windows.Forms.GroupBox mcg_ResultGroup;
        private System.Windows.Forms.Label mcg_rg_resultLabel;
        private System.Windows.Forms.Button bToPay;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tb_DateTime;
        private System.Windows.Forms.ToolStripStatusLabel tb_DayTotal;
        private System.Windows.Forms.GroupBox gb_total;
        private System.Windows.Forms.Label gbt_TotalLabel;
    }
}

