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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.usersViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SignLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 110);
            this.panel1.TabIndex = 11;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SignLabel.Location = new System.Drawing.Point(240, 32);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(421, 46);
            this.SignLabel.TabIndex = 0;
            this.SignLabel.Text = "Список пользователей";
            // 
            // usersViewPanel
            // 
            this.usersViewPanel.AutoScroll = true;
            this.usersViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersViewPanel.Controls.Add(this.dataGridView1);
            this.usersViewPanel.Location = new System.Drawing.Point(12, 116);
            this.usersViewPanel.Name = "usersViewPanel";
            this.usersViewPanel.Size = new System.Drawing.Size(876, 341);
            this.usersViewPanel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(842, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.roleLabel.ForeColor = System.Drawing.Color.Transparent;
            this.roleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.roleLabel.Location = new System.Drawing.Point(61, 486);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(67, 26);
            this.roleLabel.TabIndex = 14;
            this.roleLabel.Text = "Роль:";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.roleBox.Location = new System.Drawing.Point(188, 487);
            this.roleBox.MaxLength = 20;
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(200, 27);
            this.roleBox.TabIndex = 15;
            this.roleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeButton.Location = new System.Drawing.Point(586, 467);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(218, 57);
            this.changeButton.TabIndex = 28;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(586, 531);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(218, 57);
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "Закрыть окно";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.usersViewPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.usersViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label SignLabel;
        private Panel usersViewPanel;
        private DataGridView dataGridView1;
        private Label roleLabel;
        private TextBox roleBox;
        private Button changeButton;
        private Button closeButton;
    }
}