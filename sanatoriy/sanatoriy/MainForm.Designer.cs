using MySqlConnector;
using System.Data;
using System.Runtime.CompilerServices;

namespace sanatoriy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.servicesPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // servicesPanel
            // 
            this.servicesPanel.AutoScroll = true;
            this.servicesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servicesPanel.Controls.Add(this.button3);
            this.servicesPanel.Controls.Add(this.button2);
            this.servicesPanel.Controls.Add(this.button1);
            this.servicesPanel.Location = new System.Drawing.Point(1, 128);
            this.servicesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicesPanel.Name = "servicesPanel";
            this.servicesPanel.Size = new System.Drawing.Size(1119, 404);
            this.servicesPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 369);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 185);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 172);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 185);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.roleLabel);
            this.panel2.Controls.Add(this.fullNameLabel);
            this.panel2.Controls.Add(this.profileButton);
            this.panel2.Controls.Add(this.offButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 87);
            this.panel2.TabIndex = 1;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roleLabel.Location = new System.Drawing.Point(439, 42);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(199, 22);
            this.roleLabel.TabIndex = 30;
            this.roleLabel.Text = "\"Роль пользователя\"";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(414, 14);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(244, 22);
            this.fullNameLabel.TabIndex = 27;
            this.fullNameLabel.Text = "\"Имя Фамилия Отчество\"";
            this.fullNameLabel.Click += new System.EventHandler(this.fullNameLabel_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.profileButton.Location = new System.Drawing.Point(738, 42);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(382, 44);
            this.profileButton.TabIndex = 26;
            this.profileButton.Text = "Личный Кабинет";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.offButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.offButton.Location = new System.Drawing.Point(928, 0);
            this.offButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(191, 43);
            this.offButton.TabIndex = 25;
            this.offButton.Text = "Выход";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 86);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ОК \"Клей\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1120, 46);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мне: добавить кнопку изменить услугу и кнопку добавить услугу";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(450, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список Услуг";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.servicesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Страница Услуг";
            this.servicesPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void Edit()
        {
            if (idUser == -1)
            {
                this.fullNameLabel.Text = "Вы не авторизовались";
                this.roleLabel.Text = "Вы вошли как гость";
                roleUser = "guest";
                return;
            }

            DBase data = new DBase();
            DataTable table = new DataTable();
            string querystring = $"select info, role from users where id = '{idUser}'";
            MySqlCommand command = new MySqlCommand(querystring, data.GetConnection());
            data.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string infoUser = reader[0].ToString();
            roleUser = reader[1].ToString();
            reader.Close();
            data.CloseConnection();
            string[] nameAndNumber = infoUser.Split('!');
            this.fullNameLabel.Text = nameAndNumber[0];
            if (roleUser == "user")
            {
                this.roleLabel.Text = "Вы авторизовались как пользователь";
            }
            if (roleUser == "admin")
            {
                this.roleLabel.Text = "Вы авторизовались как администратор";
            }
        }

        private Panel servicesPanel;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button offButton;
        private Button profileButton;
        private Panel panel4;
        private Label label2;
        private Button button3;
        private Label label3;
        private Label fullNameLabel;
        private Label roleLabel;
    }
}