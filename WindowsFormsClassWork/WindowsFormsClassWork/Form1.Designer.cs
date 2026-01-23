namespace WindowsFormsClassWork
{
    partial class MainForms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.avgLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.imagePath = new System.Windows.Forms.PictureBox();
            this.ticketnumberLabel = new System.Windows.Forms.Label();
            this.studiontListBox = new System.Windows.Forms.ListBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePath)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.avgLabel);
            this.panel.Controls.Add(this.nameLabel);
            this.panel.Controls.Add(this.ageLabel);
            this.panel.Controls.Add(this.imagePath);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(396, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(404, 450);
            this.panel.TabIndex = 2;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avgLabel.Location = new System.Drawing.Point(4, 241);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(36, 21);
            this.avgLabel.TabIndex = 5;
            this.avgLabel.Text = "avg";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 181);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 21);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "name";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.Location = new System.Drawing.Point(4, 211);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(35, 21);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "age";
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(3, 3);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(220, 175);
            this.imagePath.TabIndex = 3;
            this.imagePath.TabStop = false;
            // 
            // ticketnumberLabel
            // 
            this.ticketnumberLabel.AutoSize = true;
            this.ticketnumberLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketnumberLabel.Location = new System.Drawing.Point(399, 271);
            this.ticketnumberLabel.Name = "ticketnumberLabel";
            this.ticketnumberLabel.Size = new System.Drawing.Size(106, 21);
            this.ticketnumberLabel.TabIndex = 6;
            this.ticketnumberLabel.Text = "ticketnumber";
            // 
            // studiontListBox
            // 
            this.studiontListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.studiontListBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studiontListBox.FormattingEnabled = true;
            this.studiontListBox.ItemHeight = 23;
            this.studiontListBox.Location = new System.Drawing.Point(0, 0);
            this.studiontListBox.Name = "studiontListBox";
            this.studiontListBox.Size = new System.Drawing.Size(393, 450);
            this.studiontListBox.TabIndex = 4;
            this.studiontListBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ticketnumberLabel);
            this.Controls.Add(this.studiontListBox);
            this.Controls.Add(this.panel);
            this.Name = "MainForms";
            this.Text = "MainForms";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox imagePath;
        private System.Windows.Forms.ListBox studiontListBox;
        private System.Windows.Forms.Label ticketnumberLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

