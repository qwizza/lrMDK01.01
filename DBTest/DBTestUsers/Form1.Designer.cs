namespace DBTestUsers
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButt = new System.Windows.Forms.Button();
            this.addButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 333);
            this.dataGridView.TabIndex = 0;
            // 
            // deleteButt
            // 
            this.deleteButt.Location = new System.Drawing.Point(725, 339);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(75, 23);
            this.deleteButt.TabIndex = 1;
            this.deleteButt.Text = "Удалить";
            this.deleteButt.UseVisualStyleBackColor = true;
            this.deleteButt.Click += new System.EventHandler(this.deleteButt_Click);
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(644, 339);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(75, 23);
            this.addButt.TabIndex = 2;
            this.addButt.Text = "Добавить";
            this.addButt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.deleteButt);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteButt;
        private System.Windows.Forms.Button addButt;
    }
}

