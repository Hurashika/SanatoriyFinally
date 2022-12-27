using MySqlConnector;

namespace sanatoriy
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.signButton = new System.Windows.Forms.Button();
            this.roleLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goServiceButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.signButton);
            this.panel2.Controls.Add(this.roleLabel);
            this.panel2.Controls.Add(this.fullNameLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.goServiceButton);
            this.panel2.Controls.Add(this.offButton);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1120, 87);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // signButton
            // 
            this.signButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.signButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.signButton.Location = new System.Drawing.Point(738, 41);
            this.signButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(382, 44);
            this.signButton.TabIndex = 27;
            this.signButton.Text = "Записаться";
            this.signButton.UseVisualStyleBackColor = false;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roleLabel.Location = new System.Drawing.Point(444, 42);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(199, 22);
            this.roleLabel.TabIndex = 29;
            this.roleLabel.Text = "\"Роль пользователя\"";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fullNameLabel.Location = new System.Drawing.Point(416, 14);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(244, 22);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "\"Имя Фамилия Отчество\"";
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
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(20, 99);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(113, 25);
            this.Label.TabIndex = 4;
            this.Label.Text = "Описание:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(149, 104);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(103, 21);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "\"Описание\"";
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(10, 488);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 43);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1120, 540);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void LoadData()
        {
            DBase data = new DBase();
            string sql = $"select info from service where id = '{serviceid}'";
            data.OpenConnection();
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            this.InfoLabel.Text = reader[0].ToString();
            reader.Close();
            data.CloseConnection();

            if(userid == -1)
            {
                this.deleteButton.Visible = false;
                return;
            }

            sql = $"select role from users where id = '{userid}'";
            command.CommandText = sql;
            data.OpenConnection();
            reader = command.ExecuteReader();
            reader.Read();
            string role = reader[0].ToString();
            reader.Close();
            if(role == "admin" || role == "doctor")
            {
                this.deleteButton.Visible = true;
            }
            else
            {
                this.deleteButton.Visible = false;
            }
            data.CloseConnection();
        }

        private Panel panel2;
        private Button goServiceButton;
        private Label fullNameLabel;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label roleLabel;
        private Button offButton;
        private Button signButton;
        private Label Label;
        private Label InfoLabel;
        private Button deleteButton;
    }
}