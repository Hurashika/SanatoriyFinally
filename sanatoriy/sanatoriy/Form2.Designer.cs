namespace sanatoriy
{
    partial class NameChangeForm
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
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ChangeLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 110);
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
            this.passLabel.Location = new System.Drawing.Point(40, 186);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 26);
            this.passLabel.TabIndex = 5;
            this.passLabel.Text = "Пароль:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(225, 182);
            this.passBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(300, 30);
            this.passBox.TabIndex = 6;
            this.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.fullnameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.fullnameLabel.Location = new System.Drawing.Point(40, 250);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(75, 26);
            this.fullnameLabel.TabIndex = 7;
            this.fullnameLabel.Text = "ФИО:";
            // 
            // fullnameBox
            // 
            this.fullnameBox.Location = new System.Drawing.Point(225, 246);
            this.fullnameBox.MinimumSize = new System.Drawing.Size(150, 30);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(300, 30);
            this.fullnameBox.TabIndex = 12;
            this.fullnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(334, 437);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(200, 50);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.autorisationButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(50, 441);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(200, 50);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
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
        private Label fullnameLabel;
        private TextBox fullnameBox;
        private Button changeButton;
        private Button closeButton;
    }
}