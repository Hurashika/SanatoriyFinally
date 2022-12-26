using MySqlConnector;

namespace sanatoriy
{
    partial class UsersListForm
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
            this.SignLabel = new System.Windows.Forms.Label();
            this.usersViewPanel = new System.Windows.Forms.Panel();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.usersViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SignLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 82);
            this.panel1.TabIndex = 11;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SignLabel.Location = new System.Drawing.Point(210, 24);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(330, 36);
            this.SignLabel.TabIndex = 0;
            this.SignLabel.Text = "Список пользователей";
            // 
            // usersViewPanel
            // 
            this.usersViewPanel.AutoScroll = true;
            this.usersViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersViewPanel.Controls.Add(this.dataUser);
            this.usersViewPanel.Location = new System.Drawing.Point(10, 87);
            this.usersViewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersViewPanel.Name = "usersViewPanel";
            this.usersViewPanel.Size = new System.Drawing.Size(767, 256);
            this.usersViewPanel.TabIndex = 12;
            // 
            // dataUser
            // 
            this.dataUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(3, 2);
            this.dataUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersWidth = 51;
            this.dataUser.RowTemplate.Height = 29;
            this.dataUser.Size = new System.Drawing.Size(737, 158);
            this.dataUser.TabIndex = 0;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.roleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.roleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.roleLabel.Location = new System.Drawing.Point(53, 364);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(55, 22);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Роль:";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.roleBox.Location = new System.Drawing.Point(164, 365);
            this.roleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roleBox.MaxLength = 20;
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(176, 23);
            this.roleBox.TabIndex = 15;
            this.roleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(513, 350);
            this.changeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(191, 43);
            this.changeButton.TabIndex = 28;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(513, 398);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 43);
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "Закрыть окно";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.usersViewPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.usersViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void LoadData()
        {
            this.dataUser.Rows.Clear();
            DBase data = new DBase();
            string sql = $"select login, role from users";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            this.dataUser.ColumnCount = 2;
            this.dataUser.Columns[0].Name = "login";
            this.dataUser.Columns[1].Name = "role";
            this.dataUser.AllowUserToAddRows = false;
            this.dataUser.RowHeadersVisible = false;
            while (reader.Read())
            {
                this.dataUser.Rows.Add(reader[0].ToString(), reader[1].ToString());
            }
            reader.Close();
            data.CloseConnection();
            
        }

        private Panel panel1;
        private Label SignLabel;
        private Panel usersViewPanel;
        private DataGridView dataUser;
        private Label roleLabel;
        private TextBox roleBox;
        private Button changeButton;
        private Button closeButton;
    }
}