namespace sanatoriy
{
    partial class AddServiceForm
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
            this.doctorLabel = new System.Windows.Forms.Label();
            this.coastLabel = new System.Windows.Forms.Label();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.doctorBox = new System.Windows.Forms.TextBox();
            this.coastBox = new System.Windows.Forms.TextBox();
            this.cabinetBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SignLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.ForeColor = System.Drawing.Color.Transparent;
            this.doctorLabel.Location = new System.Drawing.Point(77, 245);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(161, 26);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "Имя доктора:";
            // 
            // coastLabel
            // 
            this.coastLabel.AutoSize = true;
            this.coastLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.coastLabel.ForeColor = System.Drawing.Color.Transparent;
            this.coastLabel.Location = new System.Drawing.Point(77, 165);
            this.coastLabel.Name = "coastLabel";
            this.coastLabel.Size = new System.Drawing.Size(142, 26);
            this.coastLabel.TabIndex = 2;
            this.coastLabel.Text = "Цена услуги:";
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cabinetLabel.ForeColor = System.Drawing.Color.Transparent;
            this.cabinetLabel.Location = new System.Drawing.Point(77, 205);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(193, 26);
            this.cabinetLabel.TabIndex = 3;
            this.cabinetLabel.Text = "Номер кабинета:";
            this.cabinetLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(272, 125);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameBox.MaxLength = 100;
            this.nameBox.Name = "nameBox";
            this.nameBox.PlaceholderText = "Введите название";
            this.nameBox.Size = new System.Drawing.Size(500, 27);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // doctorBox
            // 
            this.doctorBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.doctorBox.Location = new System.Drawing.Point(272, 245);
            this.doctorBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.doctorBox.MaxLength = 100;
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.PlaceholderText = "Ввод имени";
            this.doctorBox.Size = new System.Drawing.Size(500, 27);
            this.doctorBox.TabIndex = 5;
            this.doctorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coastBox
            // 
            this.coastBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.coastBox.Location = new System.Drawing.Point(272, 165);
            this.coastBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coastBox.MaxLength = 20;
            this.coastBox.Name = "coastBox";
            this.coastBox.PlaceholderText = "Введите цену";
            this.coastBox.Size = new System.Drawing.Size(500, 27);
            this.coastBox.TabIndex = 6;
            this.coastBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cabinetBox
            // 
            this.cabinetBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cabinetBox.Location = new System.Drawing.Point(272, 205);
            this.cabinetBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cabinetBox.MaxLength = 10;
            this.cabinetBox.Name = "cabinetBox";
            this.cabinetBox.PlaceholderText = "Номер кабинета";
            this.cabinetBox.Size = new System.Drawing.Size(500, 27);
            this.cabinetBox.TabIndex = 7;
            this.cabinetBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(570, 500);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(200, 50);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(147, 500);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 50);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SignLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 110);
            this.panel1.TabIndex = 10;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SignLabel.Location = new System.Drawing.Point(292, 32);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(315, 46);
            this.SignLabel.TabIndex = 0;
            this.SignLabel.Text = "Добавить услугу";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(77, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(186, 26);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Название услуги:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Location = new System.Drawing.Point(77, 285);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(119, 26);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Описание:";
            // 
            // descriptionRichBox
            // 
            this.descriptionRichBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.descriptionRichBox.Location = new System.Drawing.Point(272, 285);
            this.descriptionRichBox.Name = "descriptionRichBox";
            this.descriptionRichBox.Size = new System.Drawing.Size(500, 184);
            this.descriptionRichBox.TabIndex = 25;
            this.descriptionRichBox.Text = "";
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.descriptionRichBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cabinetBox);
            this.Controls.Add(this.coastBox);
            this.Controls.Add(this.doctorBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cabinetLabel);
            this.Controls.Add(this.coastLabel);
            this.Controls.Add(this.doctorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label doctorLabel;
        private Label coastLabel;
        private Label cabinetLabel;
        private TextBox nameBox;
        private TextBox doctorBox;
        private TextBox coastBox;
        private TextBox cabinetBox;
        private Button addButton;
        private Button closeButton;
        private Panel panel1;
        private Label SignLabel;
        private Label nameLabel;
        private Label descriptionLabel;
        private RichTextBox descriptionRichBox;
    }
}