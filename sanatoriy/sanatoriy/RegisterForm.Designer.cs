namespace sanatoriy
{
    partial class RegisterForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.policeLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.tryPassLabel = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.policeBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.tryPassBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 82);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Brown;
            this.closeButton.Location = new System.Drawing.Point(481, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(44, 38);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваши данные";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fullnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Location = new System.Drawing.Point(35, 105);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(61, 22);
            this.fullnameLabel.TabIndex = 4;
            this.fullnameLabel.Text = "ФИО:";
            this.fullnameLabel.Click += new System.EventHandler(this.fullnameLabel_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Transparent;
            this.loginLabel.Location = new System.Drawing.Point(35, 135);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(68, 22);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "login:";
            // 
            // policeLabel
            // 
            this.policeLabel.AutoSize = true;
            this.policeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.policeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.policeLabel.Location = new System.Drawing.Point(35, 165);
            this.policeLabel.Name = "policeLabel";
            this.policeLabel.Size = new System.Drawing.Size(113, 22);
            this.policeLabel.TabIndex = 6;
            this.policeLabel.Text = "Мед. Полис:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.phoneLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phoneLabel.Location = new System.Drawing.Point(35, 195);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(97, 44);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Номер\r\nТелефона:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(35, 244);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(79, 22);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Пароль:";
            // 
            // tryPassLabel
            // 
            this.tryPassLabel.AutoSize = true;
            this.tryPassLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tryPassLabel.ForeColor = System.Drawing.Color.Transparent;
            this.tryPassLabel.Location = new System.Drawing.Point(35, 274);
            this.tryPassLabel.Name = "tryPassLabel";
            this.tryPassLabel.Size = new System.Drawing.Size(112, 44);
            this.tryPassLabel.TabIndex = 9;
            this.tryPassLabel.Text = "Повторите\r\nпароль:";
            this.tryPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameBox
            // 
            this.fullnameBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.fullnameBox.Location = new System.Drawing.Point(197, 102);
            this.fullnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullnameBox.MaxLength = 100;
            this.fullnameBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.PlaceholderText = "ваше Имя";
            this.fullnameBox.Size = new System.Drawing.Size(263, 23);
            this.fullnameBox.TabIndex = 11;
            this.fullnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(197, 132);
            this.loginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBox.MaxLength = 100;
            this.loginBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "ваш login";
            this.loginBox.Size = new System.Drawing.Size(263, 23);
            this.loginBox.TabIndex = 12;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // policeBox
            // 
            this.policeBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.policeBox.Location = new System.Drawing.Point(197, 162);
            this.policeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.policeBox.MaxLength = 16;
            this.policeBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.policeBox.Name = "policeBox";
            this.policeBox.PlaceholderText = "ваш полис";
            this.policeBox.Size = new System.Drawing.Size(263, 23);
            this.policeBox.TabIndex = 13;
            this.policeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneBox.Location = new System.Drawing.Point(197, 206);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneBox.MaxLength = 11;
            this.phoneBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.PlaceholderText = "ваш номер";
            this.phoneBox.Size = new System.Drawing.Size(263, 23);
            this.phoneBox.TabIndex = 14;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(197, 244);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passBox.MaxLength = 32;
            this.passBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.passBox.Name = "passBox";
            this.passBox.PlaceholderText = "ваш пароль";
            this.passBox.Size = new System.Drawing.Size(263, 23);
            this.passBox.TabIndex = 15;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tryPassBox
            // 
            this.tryPassBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tryPassBox.Location = new System.Drawing.Point(197, 284);
            this.tryPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tryPassBox.MaxLength = 32;
            this.tryPassBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.tryPassBox.Name = "tryPassBox";
            this.tryPassBox.PasswordChar = '*';
            this.tryPassBox.PlaceholderText = "Повторите пароль";
            this.tryPassBox.Size = new System.Drawing.Size(263, 23);
            this.tryPassBox.TabIndex = 16;
            this.tryPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(131, 360);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(262, 38);
            this.registrationButton.TabIndex = 17;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.tryPassBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.policeBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.tryPassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.policeLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label fullnameLabel;
        private Label loginLabel;
        private Label policeLabel;
        private Label phoneLabel;
        private Label passLabel;
        private Label tryPassLabel;
        private TextBox fullnameBox;
        private TextBox loginBox;
        private TextBox policeBox;
        private TextBox phoneBox;
        private TextBox passBox;
        private TextBox tryPassBox;
        private Button registrationButton;
        private Button closeButton;
    }
}