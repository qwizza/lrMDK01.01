namespace LR3
{
    partial class MainForm
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
            this.Group_dishesСomboBox = new System.Windows.Forms.ComboBox();
            this.MenuListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Group_dishesСomboBox
            // 
            this.Group_dishesСomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_dishesСomboBox.FormattingEnabled = true;
            this.Group_dishesСomboBox.Location = new System.Drawing.Point(12, 12);
            this.Group_dishesСomboBox.Name = "Group_dishesСomboBox";
            this.Group_dishesСomboBox.Size = new System.Drawing.Size(363, 29);
            this.Group_dishesСomboBox.TabIndex = 0;
            // 
            // MenuListBox
            // 
            this.MenuListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 21;
            this.MenuListBox.Location = new System.Drawing.Point(12, 51);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(363, 382);
            this.MenuListBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.Group_dishesСomboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Group_dishesСomboBox;
        private System.Windows.Forms.ListBox MenuListBox;
    }
}

