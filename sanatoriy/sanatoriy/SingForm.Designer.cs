namespace sanatoriy
{
    partial class SignForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignLabel = new System.Windows.Forms.Label();
            this.policeLabel = new System.Windows.Forms.Label();
            this.policeBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.serviceInfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SignLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 110);
            this.panel1.TabIndex = 2;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SignLabel.Location = new System.Drawing.Point(145, 32);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(309, 46);
            this.SignLabel.TabIndex = 0;
            this.SignLabel.Text = "Запись на услугу";
            // 
            // policeLabel
            // 
            this.policeLabel.AutoSize = true;
            this.policeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.policeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.policeLabel.Location = new System.Drawing.Point(42, 261);
            this.policeLabel.Name = "policeLabel";
            this.policeLabel.Size = new System.Drawing.Size(136, 26);
            this.policeLabel.TabIndex = 7;
            this.policeLabel.Text = "Мед. Полис:";
            // 
            // policeBox
            // 
            this.policeBox.Location = new System.Drawing.Point(225, 261);
            this.policeBox.MaxLength = 16;
            this.policeBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.policeBox.Name = "policeBox";
            this.policeBox.Size = new System.Drawing.Size(300, 30);
            this.policeBox.TabIndex = 14;
            this.policeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.infoLabel.Location = new System.Drawing.Point(69, 135);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(462, 52);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Чтобы записаться на услугу, пожалуйста, \r\nвведите Медицинский Полис";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(42, 457);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 50);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // SignButton
            // 
            this.SignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignButton.Location = new System.Drawing.Point(365, 457);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(200, 50);
            this.SignButton.TabIndex = 17;
            this.SignButton.Text = "Записаться";
            this.SignButton.UseVisualStyleBackColor = true;
            // 
            // serviceInfoLabel
            // 
            this.serviceInfoLabel.AutoSize = true;
            this.serviceInfoLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serviceInfoLabel.Location = new System.Drawing.Point(145, 375);
            this.serviceInfoLabel.Name = "serviceInfoLabel";
            this.serviceInfoLabel.Size = new System.Drawing.Size(337, 17);
            this.serviceInfoLabel.TabIndex = 18;
            this.serviceInfoLabel.Text = "\"Здесь можно вывести информацию о самой услуге\"";
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.serviceInfoLabel);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.policeBox);
            this.Controls.Add(this.policeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignForm";
            this.Text = "SingForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label SignLabel;
        private Label policeLabel;
        private TextBox policeBox;
        private Label infoLabel;
        private Button closeButton;
        private Button SignButton;
        private Label serviceInfoLabel;
    }
}