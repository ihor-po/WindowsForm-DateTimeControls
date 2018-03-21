namespace dz2_task678_7
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
            this.RadioGroup = new System.Windows.Forms.GroupBox();
            this.rbSeconds = new System.Windows.Forms.RadioButton();
            this.rbMinute = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.UserDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDate = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResTextLabel = new System.Windows.Forms.Label();
            this.ResCalcLabel = new System.Windows.Forms.Label();
            this.ExitB = new System.Windows.Forms.Button();
            this.RadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioGroup
            // 
            this.RadioGroup.Controls.Add(this.rbSeconds);
            this.RadioGroup.Controls.Add(this.rbMinute);
            this.RadioGroup.Controls.Add(this.rbDay);
            this.RadioGroup.Controls.Add(this.rbMonth);
            this.RadioGroup.Controls.Add(this.rbYear);
            this.RadioGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioGroup.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RadioGroup.Location = new System.Drawing.Point(14, 119);
            this.RadioGroup.Name = "RadioGroup";
            this.RadioGroup.Size = new System.Drawing.Size(324, 130);
            this.RadioGroup.TabIndex = 0;
            this.RadioGroup.TabStop = false;
            this.RadioGroup.Text = "Формат результата";
            // 
            // rbSeconds
            // 
            this.rbSeconds.AutoSize = true;
            this.rbSeconds.Location = new System.Drawing.Point(165, 58);
            this.rbSeconds.Name = "rbSeconds";
            this.rbSeconds.Size = new System.Drawing.Size(108, 24);
            this.rbSeconds.TabIndex = 4;
            this.rbSeconds.Text = "в секундах";
            this.rbSeconds.UseVisualStyleBackColor = true;
            // 
            // rbMinute
            // 
            this.rbMinute.AutoSize = true;
            this.rbMinute.Location = new System.Drawing.Point(165, 27);
            this.rbMinute.Name = "rbMinute";
            this.rbMinute.Size = new System.Drawing.Size(101, 24);
            this.rbMinute.TabIndex = 3;
            this.rbMinute.Text = "в минутах";
            this.rbMinute.UseVisualStyleBackColor = true;
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(15, 89);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(76, 24);
            this.rbDay.TabIndex = 2;
            this.rbDay.Text = "в днях";
            this.rbDay.UseVisualStyleBackColor = true;
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(15, 58);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(102, 24);
            this.rbMonth.TabIndex = 1;
            this.rbMonth.Text = "в месяцах";
            this.rbMonth.UseVisualStyleBackColor = true;
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Checked = true;
            this.rbYear.Location = new System.Drawing.Point(15, 27);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(83, 24);
            this.rbYear.TabIndex = 0;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "в годах";
            this.rbYear.UseVisualStyleBackColor = true;
            // 
            // UserDateLabel
            // 
            this.UserDateLabel.AutoSize = true;
            this.UserDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDateLabel.Location = new System.Drawing.Point(22, 27);
            this.UserDateLabel.Name = "UserDateLabel";
            this.UserDateLabel.Size = new System.Drawing.Size(116, 20);
            this.UserDateLabel.TabIndex = 3;
            this.UserDateLabel.Text = "Введите дату";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "гггг - мм - дд";
            // 
            // UserDate
            // 
            this.UserDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDate.Location = new System.Drawing.Point(144, 23);
            this.UserDate.MaxLength = 10;
            this.UserDate.Name = "UserDate";
            this.UserDate.Size = new System.Drawing.Size(100, 29);
            this.UserDate.TabIndex = 5;
            this.UserDate.Text = "00-00-0000";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(359, 166);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(121, 31);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(360, 130);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(119, 30);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::dz2_task678_7.Properties.Resources.previziuni;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(359, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 84);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ResTextLabel
            // 
            this.ResTextLabel.AutoSize = true;
            this.ResTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResTextLabel.Location = new System.Drawing.Point(22, 86);
            this.ResTextLabel.Name = "ResTextLabel";
            this.ResTextLabel.Size = new System.Drawing.Size(118, 24);
            this.ResTextLabel.TabIndex = 10;
            this.ResTextLabel.Text = "Результат:";
            this.ResTextLabel.Visible = false;
            // 
            // ResCalcLabel
            // 
            this.ResCalcLabel.AutoSize = true;
            this.ResCalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResCalcLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ResCalcLabel.Location = new System.Drawing.Point(142, 87);
            this.ResCalcLabel.Name = "ResCalcLabel";
            this.ResCalcLabel.Size = new System.Drawing.Size(66, 24);
            this.ResCalcLabel.TabIndex = 11;
            this.ResCalcLabel.Text = "label3";
            this.ResCalcLabel.Visible = false;
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitB.Location = new System.Drawing.Point(359, 205);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(121, 41);
            this.ExitB.TabIndex = 12;
            this.ExitB.Text = "Выход";
            this.ExitB.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.ResCalcLabel);
            this.Controls.Add(this.ResTextLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDate);
            this.Controls.Add(this.UserDateLabel);
            this.Controls.Add(this.RadioGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculating the time interval";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RadioGroup.ResumeLayout(false);
            this.RadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RadioGroup;
        private System.Windows.Forms.RadioButton rbSeconds;
        private System.Windows.Forms.RadioButton rbMinute;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.Label UserDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserDate;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ResTextLabel;
        private System.Windows.Forms.Label ResCalcLabel;
        private System.Windows.Forms.Button ExitB;
    }
}

