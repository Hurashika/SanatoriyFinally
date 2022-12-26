using MySqlConnector;
using System.Data.Common;

namespace sanatoriy
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.userViewButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goServiceButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.passProfileLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.roleProfileLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.phoneProfileLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.policeProfileLabel = new System.Windows.Forms.Label();
            this.policeLabel = new System.Windows.Forms.Label();
            this.loginProfileLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.nameProfileLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userService = new System.Windows.Forms.DataGridView();
            this.ButtomColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userViewButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.goServiceButton);
            this.panel2.Controls.Add(this.offButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 87);
            this.panel2.TabIndex = 3;
            // 
            // userViewButton
            // 
            this.userViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.userViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.userViewButton.Location = new System.Drawing.Point(738, 42);
            this.userViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userViewButton.Name = "userViewButton";
            this.userViewButton.Size = new System.Drawing.Size(382, 44);
            this.userViewButton.TabIndex = 35;
            this.userViewButton.Text = "Список пользователей";
            this.userViewButton.UseVisualStyleBackColor = false;
            this.userViewButton.Click += new System.EventHandler(this.userViewButton_Click);
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
            // goServiceButton
            // 
            this.goServiceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.goServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.goServiceButton.Location = new System.Drawing.Point(738, 0);
            this.goServiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goServiceButton.Name = "goServiceButton";
            this.goServiceButton.Size = new System.Drawing.Size(191, 43);
            this.goServiceButton.TabIndex = 27;
            this.goServiceButton.Text = "Услуги";
            this.goServiceButton.UseVisualStyleBackColor = false;
            this.goServiceButton.Click += new System.EventHandler(this.goServiceButton_Click);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.offButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.offButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.offButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.offButton.Location = new System.Drawing.Point(929, 0);
            this.offButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(191, 43);
            this.offButton.TabIndex = 28;
            this.offButton.Text = "Выход";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cabinetLabel.Location = new System.Drawing.Point(416, 109);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(271, 36);
            this.cabinetLabel.TabIndex = 30;
            this.cabinetLabel.Text = "Личный Кабинет";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.changeButton);
            this.panel1.Controls.Add(this.passProfileLabel);
            this.panel1.Controls.Add(this.passLabel);
            this.panel1.Controls.Add(this.profileLabel);
            this.panel1.Controls.Add(this.roleProfileLabel);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.phoneProfileLabel);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.policeProfileLabel);
            this.panel1.Controls.Add(this.policeLabel);
            this.panel1.Controls.Add(this.loginProfileLabel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.nameProfileLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(10, 161);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 370);
            this.panel1.TabIndex = 31;
            // 
            // changeButton
            // 
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(120, 308);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(175, 38);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // passProfileLabel
            // 
            this.passProfileLabel.AutoSize = true;
            this.passProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.passProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passProfileLabel.Location = new System.Drawing.Point(155, 197);
            this.passProfileLabel.Name = "passProfileLabel";
            this.passProfileLabel.Size = new System.Drawing.Size(102, 19);
            this.passProfileLabel.TabIndex = 17;
            this.passProfileLabel.Text = "\"ваш пароль\"";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passLabel.Location = new System.Drawing.Point(24, 197);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(79, 22);
            this.passLabel.TabIndex = 16;
            this.passLabel.Text = "Пароль:";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.profileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.profileLabel.Location = new System.Drawing.Point(111, 19);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(165, 25);
            this.profileLabel.TabIndex = 15;
            this.profileLabel.Text = "Личные данные";
            // 
            // roleProfileLabel
            // 
            this.roleProfileLabel.AutoSize = true;
            this.roleProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.roleProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.roleProfileLabel.Location = new System.Drawing.Point(156, 225);
            this.roleProfileLabel.Name = "roleProfileLabel";
            this.roleProfileLabel.Size = new System.Drawing.Size(94, 19);
            this.roleProfileLabel.TabIndex = 14;
            this.roleProfileLabel.Text = "\"ваша роль\"";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label.Location = new System.Drawing.Point(24, 225);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 22);
            this.label.TabIndex = 13;
            this.label.Text = "Роль:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneProfileLabel
            // 
            this.phoneProfileLabel.AutoSize = true;
            this.phoneProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.phoneProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.phoneProfileLabel.Location = new System.Drawing.Point(156, 170);
            this.phoneProfileLabel.Name = "phoneProfileLabel";
            this.phoneProfileLabel.Size = new System.Drawing.Size(168, 19);
            this.phoneProfileLabel.TabIndex = 12;
            this.phoneProfileLabel.Text = "\"ваш номер телефона\"";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.ForeColor = System.Drawing.Color.Transparent;
            this.phoneLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.phoneLabel.Location = new System.Drawing.Point(24, 166);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(87, 22);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Телефон:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // policeProfileLabel
            // 
            this.policeProfileLabel.AutoSize = true;
            this.policeProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.policeProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.policeProfileLabel.Location = new System.Drawing.Point(156, 141);
            this.policeProfileLabel.Name = "policeProfileLabel";
            this.policeProfileLabel.Size = new System.Drawing.Size(127, 19);
            this.policeProfileLabel.TabIndex = 10;
            this.policeProfileLabel.Text = "\"ваш мед. полис\"";
            // 
            // policeLabel
            // 
            this.policeLabel.AutoSize = true;
            this.policeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.policeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.policeLabel.Location = new System.Drawing.Point(24, 138);
            this.policeLabel.Name = "policeLabel";
            this.policeLabel.Size = new System.Drawing.Size(113, 22);
            this.policeLabel.TabIndex = 9;
            this.policeLabel.Text = "Мед. Полис:";
            // 
            // loginProfileLabel
            // 
            this.loginProfileLabel.AutoSize = true;
            this.loginProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loginProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.loginProfileLabel.Location = new System.Drawing.Point(156, 112);
            this.loginProfileLabel.Name = "loginProfileLabel";
            this.loginProfileLabel.Size = new System.Drawing.Size(93, 19);
            this.loginProfileLabel.TabIndex = 8;
            this.loginProfileLabel.Text = "\"ваш логин\"";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.Transparent;
            this.loginLabel.Location = new System.Drawing.Point(32, 109);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(58, 22);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "login:";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // nameProfileLabel
            // 
            this.nameProfileLabel.AutoSize = true;
            this.nameProfileLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nameProfileLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nameProfileLabel.Location = new System.Drawing.Point(156, 80);
            this.nameProfileLabel.Name = "nameProfileLabel";
            this.nameProfileLabel.Size = new System.Drawing.Size(164, 19);
            this.nameProfileLabel.TabIndex = 6;
            this.nameProfileLabel.Text = "\"ваши фамилия и имя\"";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(24, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 22);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(888, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 32;
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.servicesLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.servicesLabel.ForeColor = System.Drawing.Color.Transparent;
            this.servicesLabel.Location = new System.Drawing.Point(130, 20);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(140, 25);
            this.servicesLabel.TabIndex = 33;
            this.servicesLabel.Text = "Ваши записи";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.panel4.Controls.Add(this.userService);
            this.panel4.Controls.Add(this.servicesLabel);
            this.panel4.Location = new System.Drawing.Point(704, 161);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 370);
            this.panel4.TabIndex = 34;
            // 
            // userService
            // 
            this.userService.AllowUserToAddRows = false;
            this.userService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.userService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ButtomColumn});
            this.userService.Location = new System.Drawing.Point(3, 67);
            this.userService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userService.Name = "userService";
            this.userService.RowHeadersVisible = false;
            this.userService.RowHeadersWidth = 51;
            this.userService.RowTemplate.Height = 29;
            this.userService.Size = new System.Drawing.Size(381, 400);
            this.userService.TabIndex = 34;
            // 
            // ButtomColumn
            // 
            this.ButtomColumn.Name = "ButtomColumn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "кнопка дать роль видна только админу";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 540);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cabinetLabel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProfileForm";
            this.Text = "UserCabinetForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void LoadInfo()
        {
            DBase data = new DBase();
            string sql = $"select info, login, pass, role from users where id = '{idUser}'";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string infoUser = reader[0].ToString();
                string[] infos = infoUser.Split('!');
                this.nameProfileLabel.Text = infos[0];
                this.loginProfileLabel.Text = reader[1].ToString();
                this.policeProfileLabel.Text = infos[2];
                this.phoneProfileLabel.Text = infos[1];
                this.passProfileLabel.Text = reader[2].ToString();
                this.roleProfileLabel.Text = reader[3].ToString();
            }
            reader.Close();
            data.CloseConnection();
            
            
            sql = $"select service from users where id = '{idUser}'";
            MySqlCommand servicecommand = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            MySqlDataReader servicereader = servicecommand.ExecuteReader();
            servicereader.Read();
            string[] services = servicereader[0].ToString().Split('!');
            servicereader.Close();
            data.CloseConnection();

            this.userService.ColumnCount = 1;
            this.userService.ReadOnly = true;
            this.userService.AllowUserToAddRows = false;
            this.userService.Columns[0].Width = 400;
            this.userService.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.userService.Columns[0].Name = "Название услуги";

            for(int i = 0; i < services.Length; i++)
            {
                if (services[i] == "")
                    continue;
                data.OpenConnection();
                sql = $"select name_of_service from service where id = '{int.Parse(services[i])}'";
                MySqlCommand namecommand = new MySqlCommand(sql, data.GetConnection());
                MySqlDataReader namereader = namecommand.ExecuteReader();
                namereader.Read();
                this.userService.Rows.Add(namereader[0].ToString());
                namereader.Close();
                data.CloseConnection();
            }

        }

        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button goServiceButton;
        private Button offButton;
        private Label cabinetLabel;
        private Panel panel1;
        private Label nameLabel;
        private Label nameProfileLabel;
        private Label loginLabel;
        private Label loginProfileLabel;
        private Label policeProfileLabel;
        private Label policeLabel;
        private Label phoneProfileLabel;
        private Label phoneLabel;
        private Label profileLabel;
        private Label roleProfileLabel;
        private Label label;
        private Label passProfileLabel;
        private Label passLabel;
        private Label label2;
        private Button changeButton;
        private Label servicesLabel;
        private Panel panel4;
        private Button userViewButton;
        private Label label4;
        private DataGridView userService;
        private DataGridViewButtonColumn ButtomColumn;
    }
}