namespace dz2_task678
{
    partial class DateTimeForm
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
            this.UserDate = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UserDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultTextLabel = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserDate
            // 
            this.UserDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDate.Location = new System.Drawing.Point(154, 31);
            this.UserDate.MaxLength = 10;
            this.UserDate.Name = "UserDate";
            this.UserDate.Size = new System.Drawing.Size(100, 29);
            this.UserDate.TabIndex = 0;
            this.UserDate.Text = "00-00-0000";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(273, 30);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(119, 30);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Вычислить";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // UserDateLabel
            // 
            this.UserDateLabel.AutoSize = true;
            this.UserDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDateLabel.Location = new System.Drawing.Point(23, 36);
            this.UserDateLabel.Name = "UserDateLabel";
            this.UserDateLabel.Size = new System.Drawing.Size(116, 20);
            this.UserDateLabel.TabIndex = 2;
            this.UserDateLabel.Text = "Введите дату";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "гггг - мм - дд";
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(273, 66);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(119, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ResultTextLabel
            // 
            this.ResultTextLabel.AutoSize = true;
            this.ResultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextLabel.Location = new System.Drawing.Point(55, 127);
            this.ResultTextLabel.Name = "ResultTextLabel";
            this.ResultTextLabel.Size = new System.Drawing.Size(84, 20);
            this.ResultTextLabel.TabIndex = 6;
            this.ResultTextLabel.Text = "Ваш день";
            this.ResultTextLabel.Visible = false;
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultText.Location = new System.Drawing.Point(153, 122);
            this.ResultText.MaxLength = 10;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(127, 29);
            this.ResultText.TabIndex = 7;
            this.ResultText.Visible = false;
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 200);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.ResultTextLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDateLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.UserDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Count day Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserDate;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label UserDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ResultTextLabel;
        private System.Windows.Forms.TextBox ResultText;
    }
}

