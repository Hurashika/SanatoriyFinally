namespace sanatoriy
{
    partial class NewServiceform
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.descriptionRichBox = new System.Windows.Forms.RichTextBox();
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
            this.panel1.TabIndex = 3;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SignLabel.Location = new System.Drawing.Point(145, 32);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(315, 46);
            this.SignLabel.TabIndex = 0;
            this.SignLabel.Text = "Добавить услугу";
            this.SignLabel.Click += new System.EventHandler(this.SignLabel_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(50, 481);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 50);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SignButton
            // 
            this.SignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignButton.Location = new System.Drawing.Point(350, 481);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(200, 50);
            this.SignButton.TabIndex = 18;
            this.SignButton.Text = "Записаться";
            this.SignButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.priceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.priceLabel.Location = new System.Drawing.Point(50, 161);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 26);
            this.priceLabel.TabIndex = 19;
            this.priceLabel.Text = "Цена:";
            this.priceLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(50, 213);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 26);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Описание:";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceBox.Location = new System.Drawing.Point(229, 161);
            this.priceBox.MaxLength = 32;
            this.priceBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(300, 30);
            this.priceBox.TabIndex = 22;
            this.priceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionRichBox
            // 
            this.descriptionRichBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.descriptionRichBox.Location = new System.Drawing.Point(229, 213);
            this.descriptionRichBox.Name = "descriptionRichBox";
            this.descriptionRichBox.Size = new System.Drawing.Size(300, 230);
            this.descriptionRichBox.TabIndex = 24;
            this.descriptionRichBox.Text = "";
            // 
            // NewServiceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.descriptionRichBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewServiceform";
            this.Text = "NewServiceform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label SignLabel;
        private Button cancelButton;
        private Button SignButton;
        private Label priceLabel;
        private Label descriptionLabel;
        private TextBox priceBox;
        private RichTextBox descriptionRichBox;
    }
}