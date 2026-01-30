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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameDish = new System.Windows.Forms.Label();
            this.descriptionDish = new System.Windows.Forms.Label();
            this.priceDish = new System.Windows.Forms.Label();
            this.ingredients = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_dishesСomboBox
            // 
            this.Group_dishesСomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_dishesСomboBox.FormattingEnabled = true;
            this.Group_dishesСomboBox.Location = new System.Drawing.Point(12, 24);
            this.Group_dishesСomboBox.Name = "Group_dishesСomboBox";
            this.Group_dishesСomboBox.Size = new System.Drawing.Size(363, 29);
            this.Group_dishesСomboBox.TabIndex = 0;
            // 
            // MenuListBox
            // 
            this.MenuListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 21;
            this.MenuListBox.Location = new System.Drawing.Point(12, 72);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(363, 361);
            this.MenuListBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 136);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(301, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ingredients);
            this.panel1.Controls.Add(this.priceDish);
            this.panel1.Controls.Add(this.descriptionDish);
            this.panel1.Controls.Add(this.nameDish);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(381, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 421);
            this.panel1.TabIndex = 4;
            // 
            // nameDish
            // 
            this.nameDish.AutoSize = true;
            this.nameDish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDish.Location = new System.Drawing.Point(3, 3);
            this.nameDish.Name = "nameDish";
            this.nameDish.Size = new System.Drawing.Size(83, 21);
            this.nameDish.TabIndex = 4;
            this.nameDish.Text = "nameDish";
            // 
            // descriptionDish
            // 
            this.descriptionDish.AutoSize = true;
            this.descriptionDish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionDish.Location = new System.Drawing.Point(3, 60);
            this.descriptionDish.Name = "descriptionDish";
            this.descriptionDish.Size = new System.Drawing.Size(127, 21);
            this.descriptionDish.TabIndex = 5;
            this.descriptionDish.Text = "descriptionDish";
            // 
            // priceDish
            // 
            this.priceDish.AutoSize = true;
            this.priceDish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceDish.Location = new System.Drawing.Point(214, 382);
            this.priceDish.Name = "priceDish";
            this.priceDish.Size = new System.Drawing.Size(81, 21);
            this.priceDish.TabIndex = 6;
            this.priceDish.Text = "priceDish";
            // 
            // ingredients
            // 
            this.ingredients.AutoSize = true;
            this.ingredients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredients.Location = new System.Drawing.Point(3, 152);
            this.ingredients.Name = "ingredients";
            this.ingredients.Size = new System.Drawing.Size(90, 21);
            this.ingredients.TabIndex = 7;
            this.ingredients.Text = "ingredients";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.Group_dishesСomboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Group_dishesСomboBox;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ingredients;
        private System.Windows.Forms.Label priceDish;
        private System.Windows.Forms.Label descriptionDish;
        private System.Windows.Forms.Label nameDish;
    }
}

