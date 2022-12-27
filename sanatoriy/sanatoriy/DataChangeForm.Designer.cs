namespace sanatoriy
{
    partial class ChangeForm
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
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.newFullnameLabel = new System.Windows.Forms.Label();
            this.newFullnameBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.newLoginBox = new System.Windows.Forms.TextBox();
            this.newPoliceLabel = new System.Windows.Forms.Label();
            this.newPoliceBox = new System.Windows.Forms.TextBox();
            this.newPhoneLabel = new System.Windows.Forms.Label();
            this.newPhoneBox = new System.Windows.Forms.TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.newPassBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ChangeLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 109);
            this.panel1.TabIndex = 1;
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ChangeLabel.Location = new System.Drawing.Point(122, 32);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(355, 46);
            this.ChangeLabel.TabIndex = 0;
            this.ChangeLabel.Text = "Изменение данных";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(40, 160);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 26);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Пароль:";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(225, 160);
            this.passBox.MaxLength = 32;
            this.passBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.PlaceholderText = "Введите ваш пароль";
            this.passBox.Size = new System.Drawing.Size(300, 27);
            this.passBox.TabIndex = 6;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newFullnameLabel
            // 
            this.newFullnameLabel.AutoSize = true;
            this.newFullnameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newFullnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.newFullnameLabel.Location = new System.Drawing.Point(40, 200);
            this.newFullnameLabel.Name = "newFullnameLabel";
            this.newFullnameLabel.Size = new System.Drawing.Size(75, 26);
            this.newFullnameLabel.TabIndex = 7;
            this.newFullnameLabel.Text = "ФИО:";
            // 
            // newFullnameBox
            // 
            this.newFullnameBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.newFullnameBox.Location = new System.Drawing.Point(225, 200);
            this.newFullnameBox.MaxLength = 100;
            this.newFullnameBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.newFullnameBox.Name = "newFullnameBox";
            this.newFullnameBox.PlaceholderText = "Введите новое имя";
            this.newFullnameBox.Size = new System.Drawing.Size(300, 27);
            this.newFullnameBox.TabIndex = 12;
            this.newFullnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(350, 441);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(200, 51);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.autorisationButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(50, 441);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 51);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.infoLabel.ForeColor = System.Drawing.Color.Transparent;
            this.infoLabel.Location = new System.Drawing.Point(66, 113);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(502, 36);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Если вы что-то не хотите менять, ничего не пишите в ненужном поле.\r\nВвод пароля о" +
    "бязателен.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newEmailLabel.ForeColor = System.Drawing.Color.Transparent;
            this.newEmailLabel.Location = new System.Drawing.Point(40, 240);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(67, 26);
            this.newEmailLabel.TabIndex = 17;
            this.newEmailLabel.Text = "login:";
            // 
            // newLoginBox
            // 
            this.newLoginBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.newLoginBox.Location = new System.Drawing.Point(225, 240);
            this.newLoginBox.MaxLength = 100;
            this.newLoginBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.newLoginBox.Name = "newLoginBox";
            this.newLoginBox.PlaceholderText = "Введите новый email";
            this.newLoginBox.Size = new System.Drawing.Size(300, 27);
            this.newLoginBox.TabIndex = 18;
            this.newLoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPoliceLabel
            // 
            this.newPoliceLabel.AutoSize = true;
            this.newPoliceLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newPoliceLabel.ForeColor = System.Drawing.Color.Transparent;
            this.newPoliceLabel.Location = new System.Drawing.Point(40, 280);
            this.newPoliceLabel.Name = "newPoliceLabel";
            this.newPoliceLabel.Size = new System.Drawing.Size(136, 26);
            this.newPoliceLabel.TabIndex = 19;
            this.newPoliceLabel.Text = "Мед. Полис:";
            // 
            // newPoliceBox
            // 
            this.newPoliceBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPoliceBox.Location = new System.Drawing.Point(225, 280);
            this.newPoliceBox.MaxLength = 16;
            this.newPoliceBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.newPoliceBox.Name = "newPoliceBox";
            this.newPoliceBox.PlaceholderText = "Введите новый полис";
            this.newPoliceBox.Size = new System.Drawing.Size(300, 27);
            this.newPoliceBox.TabIndex = 20;
            this.newPoliceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPhoneLabel
            // 
            this.newPhoneLabel.AutoSize = true;
            this.newPhoneLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newPhoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.newPhoneLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.newPhoneLabel.Location = new System.Drawing.Point(40, 320);
            this.newPhoneLabel.Name = "newPhoneLabel";
            this.newPhoneLabel.Size = new System.Drawing.Size(104, 26);
            this.newPhoneLabel.TabIndex = 21;
            this.newPhoneLabel.Text = "Телефон:";
            this.newPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPhoneBox
            // 
            this.newPhoneBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPhoneBox.Location = new System.Drawing.Point(225, 320);
            this.newPhoneBox.MaxLength = 11;
            this.newPhoneBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.newPhoneBox.Name = "newPhoneBox";
            this.newPhoneBox.PlaceholderText = "Введите новый телефон";
            this.newPhoneBox.Size = new System.Drawing.Size(300, 27);
            this.newPhoneBox.TabIndex = 22;
            this.newPhoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newPassLabel.ForeColor = System.Drawing.Color.Transparent;
            this.newPassLabel.Location = new System.Drawing.Point(40, 360);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(165, 26);
            this.newPassLabel.TabIndex = 23;
            this.newPassLabel.Text = "Новый пароль:";
            this.newPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPassBox
            // 
            this.newPassBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassBox.Location = new System.Drawing.Point(225, 360);
            this.newPassBox.MaxLength = 32;
            this.newPassBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.PlaceholderText = "Введите новый пароль";
            this.newPassBox.Size = new System.Drawing.Size(300, 27);
            this.newPassBox.TabIndex = 24;
            this.newPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.newPassBox);
            this.Controls.Add(this.newPassLabel);
            this.Controls.Add(this.newPhoneBox);
            this.Controls.Add(this.newPhoneLabel);
            this.Controls.Add(this.newPoliceBox);
            this.Controls.Add(this.newPoliceLabel);
            this.Controls.Add(this.newLoginBox);
            this.Controls.Add(this.newEmailLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newFullnameBox);
            this.Controls.Add(this.newFullnameLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label ChangeLabel;
        private Label passLabel;
        private TextBox passBox;
        private Label newFullnameLabel;
        private TextBox newFullnameBox;
        private Button changeButton;
        private Button cancelButton;
        private Label infoLabel;
        private Label newEmailLabel;
        private TextBox newLoginBox;
        private Label newPoliceLabel;
        private TextBox newPoliceBox;
        private Label newPhoneLabel;
        private TextBox newPhoneBox;
        private Label newPassLabel;
        private TextBox newPassBox;
    }
}