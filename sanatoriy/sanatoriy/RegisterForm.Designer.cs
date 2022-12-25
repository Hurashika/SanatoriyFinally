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
            this.emailLabel = new System.Windows.Forms.Label();
            this.policeLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.tryPassLabel = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 110);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Brown;
            this.closeButton.Location = new System.Drawing.Point(550, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваши данные";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fullnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Location = new System.Drawing.Point(40, 140);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(75, 26);
            this.fullnameLabel.TabIndex = 4;
            this.fullnameLabel.Text = "ФИО:";
            this.fullnameLabel.Click += new System.EventHandler(this.fullnameLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(40, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(80, 26);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "e-mail:";
            // 
            // policeLabel
            // 
            this.policeLabel.AutoSize = true;
            this.policeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.policeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.policeLabel.Location = new System.Drawing.Point(40, 220);
            this.policeLabel.Name = "policeLabel";
            this.policeLabel.Size = new System.Drawing.Size(136, 26);
            this.policeLabel.TabIndex = 6;
            this.policeLabel.Text = "Мед. Полис:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.phoneLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phoneLabel.Location = new System.Drawing.Point(40, 260);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(116, 52);
            this.phoneLabel.TabIndex = 7;
            this.phoneLabel.Text = "Номер\r\nТелефона:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(40, 325);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 26);
            this.passLabel.TabIndex = 8;
            this.passLabel.Text = "Пароль:";
            // 
            // tryPassLabel
            // 
            this.tryPassLabel.AutoSize = true;
            this.tryPassLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tryPassLabel.ForeColor = System.Drawing.Color.Transparent;
            this.tryPassLabel.Location = new System.Drawing.Point(40, 365);
            this.tryPassLabel.Name = "tryPassLabel";
            this.tryPassLabel.Size = new System.Drawing.Size(135, 52);
            this.tryPassLabel.TabIndex = 9;
            this.tryPassLabel.Text = "Повторите\r\nпароль:";
            this.tryPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullnameBox
            // 
            this.fullnameBox.Location = new System.Drawing.Point(225, 136);
            this.fullnameBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(300, 30);
            this.fullnameBox.TabIndex = 11;
            this.fullnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(225, 176);
            this.emailBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(300, 30);
            this.emailBox.TabIndex = 12;
            this.emailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // policeBox
            // 
            this.policeBox.Location = new System.Drawing.Point(225, 216);
            this.policeBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.policeBox.Name = "policeBox";
            this.policeBox.Size = new System.Drawing.Size(300, 30);
            this.policeBox.TabIndex = 13;
            this.policeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(225, 274);
            this.phoneBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(300, 30);
            this.phoneBox.TabIndex = 14;
            this.phoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(225, 326);
            this.passBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(300, 30);
            this.passBox.TabIndex = 15;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tryPassBox
            // 
            this.tryPassBox.Location = new System.Drawing.Point(225, 379);
            this.tryPassBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.tryPassBox.Name = "tryPassBox";
            this.tryPassBox.PasswordChar = '*';
            this.tryPassBox.Size = new System.Drawing.Size(300, 30);
            this.tryPassBox.TabIndex = 16;
            this.tryPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(150, 480);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(300, 50);
            this.registrationButton.TabIndex = 17;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.tryPassBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.policeBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.tryPassLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.policeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
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
        private Label emailLabel;
        private Label policeLabel;
        private Label phoneLabel;
        private Label passLabel;
        private Label tryPassLabel;
        private TextBox fullnameBox;
        private TextBox emailBox;
        private TextBox policeBox;
        private TextBox phoneBox;
        private TextBox passBox;
        private TextBox tryPassBox;
        private Button registrationButton;
        private Button closeButton;
    }
}