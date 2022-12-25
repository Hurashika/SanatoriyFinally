using System.Runtime.CompilerServices;

namespace sanatoriy
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.autorisationButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorizationText
            // 
            this.authorizationText.BackColor = System.Drawing.Color.White;
            this.authorizationText.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.authorizationText.ForeColor = System.Drawing.Color.Black;
            this.authorizationText.Location = new System.Drawing.Point(0, 0);
            this.authorizationText.Name = "authorizationText";
            this.authorizationText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.authorizationText.Size = new System.Drawing.Size(525, 82);
            this.authorizationText.TabIndex = 0;
            this.authorizationText.Text = "Авторизация";
            this.authorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Transparent;
            this.loginLabel.Location = new System.Drawing.Point(35, 140);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(67, 22);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(35, 184);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(79, 22);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль:";
            this.passLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(197, 136);
            this.loginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBox.MaxLength = 100;
            this.loginBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.loginBox.Name = "loginBox";
            this.loginBox.PlaceholderText = "Введите ваш login";
            this.loginBox.Size = new System.Drawing.Size(263, 23);
            this.loginBox.TabIndex = 4;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(197, 181);
            this.passBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passBox.MaxLength = 32;
            this.passBox.MinimumSize = new System.Drawing.Size(132, 30);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.PlaceholderText = "Введите ваш пароль";
            this.passBox.Size = new System.Drawing.Size(263, 23);
            this.passBox.TabIndex = 5;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autorisationButton
            // 
            this.autorisationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorisationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autorisationButton.Location = new System.Drawing.Point(44, 331);
            this.autorisationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorisationButton.Name = "autorisationButton";
            this.autorisationButton.Size = new System.Drawing.Size(175, 38);
            this.autorisationButton.TabIndex = 6;
            this.autorisationButton.Text = "Войти";
            this.autorisationButton.UseVisualStyleBackColor = true;
            this.autorisationButton.Click += new System.EventHandler(this.autorisationButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(306, 331);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(175, 38);
            this.registrationButton.TabIndex = 7;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guestButton.Location = new System.Drawing.Point(197, 398);
            this.guestButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(131, 26);
            this.guestButton.TabIndex = 8;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.guestButton_click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.autorisationButton);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.authorizationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label authorizationText;
        private Button closeButton;
        private Label loginLabel;
        private Label passLabel;
        private TextBox loginBox;
        private TextBox passBox;
        private Button autorisationButton;
        private Button registrationButton;
        private Button guestButton;
    }
}