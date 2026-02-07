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
            this.pictureDish = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDishName = new System.Windows.Forms.Label();
            this.priceDish = new System.Windows.Forms.Label();
            this.labelSelectGroup = new System.Windows.Forms.Label();
            this.labelSelectDish = new System.Windows.Forms.Label();
            this.labelOrderStatus = new System.Windows.Forms.Label();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).BeginInit();
            this.panelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_dishesСomboBox
            // 
            this.Group_dishesСomboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_dishesСomboBox.FormattingEnabled = true;
            this.Group_dishesСomboBox.Location = new System.Drawing.Point(164, 36);
            this.Group_dishesСomboBox.Name = "Group_dishesСomboBox";
            this.Group_dishesСomboBox.Size = new System.Drawing.Size(624, 29);
            this.Group_dishesСomboBox.TabIndex = 0;
            this.Group_dishesСomboBox.Text = "Блюда";
            // 
            // MenuListBox
            // 
            this.MenuListBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuListBox.FormattingEnabled = true;
            this.MenuListBox.ItemHeight = 21;
            this.MenuListBox.Location = new System.Drawing.Point(12, 36);
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(146, 319);
            this.MenuListBox.TabIndex = 1;
            // 
            // pictureDish
            // 
            this.pictureDish.Location = new System.Drawing.Point(482, 3);
            this.pictureDish.Name = "pictureDish";
            this.pictureDish.Size = new System.Drawing.Size(140, 140);
            this.pictureDish.TabIndex = 2;
            this.pictureDish.TabStop = false;
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
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.textBoxOrder);
            this.panelOrder.Controls.Add(this.btnAddToOrder);
            this.panelOrder.Controls.Add(this.numericUpDownQuantity);
            this.panelOrder.Controls.Add(this.labelIngredients);
            this.panelOrder.Controls.Add(this.labelPrice);
            this.panelOrder.Controls.Add(this.labelDescription);
            this.panelOrder.Controls.Add(this.labelDishName);
            this.panelOrder.Controls.Add(this.priceDish);
            this.panelOrder.Controls.Add(this.pictureDish);
            this.panelOrder.Controls.Add(this.button1);
            this.panelOrder.Location = new System.Drawing.Point(164, 71);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(624, 228);
            this.panelOrder.TabIndex = 4;
           
            // 
            // textBoxOrder
            // 
            this.textBoxOrder.Location = new System.Drawing.Point(3, 159);
            this.textBoxOrder.Multiline = true;
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.ReadOnly = true;
            this.textBoxOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOrder.Size = new System.Drawing.Size(404, 66);
            this.textBoxOrder.TabIndex = 17;
            this.textBoxOrder.Text = "Список заказа";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(482, 185);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 30);
            this.btnAddToOrder.TabIndex = 16;
            this.btnAddToOrder.Text = "Добавить в заказ";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(482, 159);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantity.TabIndex = 15;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIngredients
            // 
            this.labelIngredients.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIngredients.Location = new System.Drawing.Point(6, 112);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(292, 41);
            this.labelIngredients.TabIndex = 11;
            this.labelIngredients.Text = "Ингредиенты:";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrice.Location = new System.Drawing.Point(5, 92);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(233, 20);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Цена:";
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(6, 37);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(289, 55);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Описание блюда";
            // 
            // labelDishName
            // 
            this.labelDishName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDishName.Location = new System.Drawing.Point(4, 12);
            this.labelDishName.Name = "labelDishName";
            this.labelDishName.Size = new System.Drawing.Size(282, 25);
            this.labelDishName.TabIndex = 8;
            this.labelDishName.Text = "Название блюда";
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
            // labelSelectGroup
            // 
            this.labelSelectGroup.AutoSize = true;
            this.labelSelectGroup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectGroup.Location = new System.Drawing.Point(13, 12);
            this.labelSelectGroup.Name = "labelSelectGroup";
            this.labelSelectGroup.Size = new System.Drawing.Size(120, 21);
            this.labelSelectGroup.TabIndex = 5;
            this.labelSelectGroup.Text = "Группа меню:";
            // 
            // labelSelectDish
            // 
            this.labelSelectDish.AutoSize = true;
            this.labelSelectDish.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectDish.Location = new System.Drawing.Point(160, 12);
            this.labelSelectDish.Name = "labelSelectDish";
            this.labelSelectDish.Size = new System.Drawing.Size(65, 21);
            this.labelSelectDish.TabIndex = 6;
            this.labelSelectDish.Text = "Блюда:";
            // 
            // labelOrderStatus
            // 
            this.labelOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOrderStatus.Location = new System.Drawing.Point(164, 315);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(284, 30);
            this.labelOrderStatus.TabIndex = 13;
            this.labelOrderStatus.Text = "Заказ пуст";
            this.labelOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.BackColor = System.Drawing.Color.LightCoral;
            this.btnClearOrder.Location = new System.Drawing.Point(646, 315);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(120, 30);
            this.btnClearOrder.TabIndex = 14;
            this.btnClearOrder.Text = "Очистить заказ";
            this.btnClearOrder.UseVisualStyleBackColor = false;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlaceOrder.Location = new System.Drawing.Point(454, 315);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(120, 30);
            this.btnPlaceOrder.TabIndex = 15;
            this.btnPlaceOrder.Text = "Заказать";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.labelOrderStatus);
            this.Controls.Add(this.labelSelectDish);
            this.Controls.Add(this.labelSelectGroup);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.MenuListBox);
            this.Controls.Add(this.Group_dishesСomboBox);
            this.Name = "MainForm";
            this.Text = "Ресторан Х";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).EndInit();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Group_dishesСomboBox;
        private System.Windows.Forms.ListBox MenuListBox;
        private System.Windows.Forms.PictureBox pictureDish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Label priceDish;
        private System.Windows.Forms.Label labelSelectGroup;
        private System.Windows.Forms.Label labelSelectDish;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDishName;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label labelOrderStatus;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}

