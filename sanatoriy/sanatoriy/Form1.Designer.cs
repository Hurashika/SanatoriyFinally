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
            this.authorizationText.Size = new System.Drawing.Size(600, 110);
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
            this.closeButton.Location = new System.Drawing.Point(550, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 50);
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
            this.loginLabel.Location = new System.Drawing.Point(40, 186);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(82, 26);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(40, 245);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 26);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Пароль:";
            this.passLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(225, 182);
            this.loginBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(300, 30);
            this.loginBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(225, 241);
            this.passBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(300, 30);
            this.passBox.TabIndex = 5;
            // 
            // autorisationButton
            // 
            this.autorisationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autorisationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autorisationButton.Location = new System.Drawing.Point(50, 441);
            this.autorisationButton.Name = "autorisationButton";
            this.autorisationButton.Size = new System.Drawing.Size(200, 50);
            this.autorisationButton.TabIndex = 6;
            this.autorisationButton.Text = "Войти";
            this.autorisationButton.UseVisualStyleBackColor = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.Location = new System.Drawing.Point(350, 441);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(200, 50);
            this.registrationButton.TabIndex = 7;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // guestButton
            // 
            this.guestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guestButton.Location = new System.Drawing.Point(225, 530);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(150, 35);
            this.guestButton.TabIndex = 8;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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