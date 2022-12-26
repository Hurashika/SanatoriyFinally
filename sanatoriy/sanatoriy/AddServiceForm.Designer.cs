namespace sanatoriy
{
    partial class AddServiceForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.coastLabel = new System.Windows.Forms.Label();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.doctorBox = new System.Windows.Forms.TextBox();
            this.coastBox = new System.Windows.Forms.TextBox();
            this.cabinetBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(102, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "название услуги:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(102, 100);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(76, 15);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "имя доктора";
            // 
            // coastLabel
            // 
            this.coastLabel.AutoSize = true;
            this.coastLabel.Location = new System.Drawing.Point(102, 137);
            this.coastLabel.Name = "coastLabel";
            this.coastLabel.Size = new System.Drawing.Size(33, 15);
            this.coastLabel.TabIndex = 2;
            this.coastLabel.Text = "цена";
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.Location = new System.Drawing.Point(102, 167);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(96, 15);
            this.cabinetLabel.TabIndex = 3;
            this.cabinetLabel.Text = "номер кабинета";
            this.cabinetLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(238, 69);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 4;
            // 
            // doctorBox
            // 
            this.doctorBox.Location = new System.Drawing.Point(238, 100);
            this.doctorBox.Name = "doctorBox";
            this.doctorBox.Size = new System.Drawing.Size(100, 23);
            this.doctorBox.TabIndex = 5;
            // 
            // coastBox
            // 
            this.coastBox.Location = new System.Drawing.Point(238, 129);
            this.coastBox.Name = "coastBox";
            this.coastBox.Size = new System.Drawing.Size(100, 23);
            this.coastBox.TabIndex = 6;
            // 
            // cabinetBox
            // 
            this.cabinetBox.Location = new System.Drawing.Point(238, 164);
            this.cabinetBox.Name = "cabinetBox";
            this.cabinetBox.Size = new System.Drawing.Size(100, 23);
            this.cabinetBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(296, 266);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(713, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cabinetBox);
            this.Controls.Add(this.coastBox);
            this.Controls.Add(this.doctorBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.cabinetLabel);
            this.Controls.Add(this.coastLabel);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddServiceForm";
            this.Text = "AddServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private Label doctorLabel;
        private Label coastLabel;
        private Label cabinetLabel;
        private TextBox nameBox;
        private TextBox doctorBox;
        private TextBox coastBox;
        private TextBox cabinetBox;
        private Button addButton;
        private Button closeButton;
    }
}