namespace LR3Сhart
{
    partial class Chart
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
            this.GenresBooks = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pieChartRevenue = new LiveCharts.WinForms.PieChart();
            this.cartesianSaleBook = new LiveCharts.WinForms.CartesianChart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenresBooks
            // 
            this.GenresBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenresBooks.FormattingEnabled = true;
            this.GenresBooks.Location = new System.Drawing.Point(0, 0);
            this.GenresBooks.Name = "GenresBooks";
            this.GenresBooks.Size = new System.Drawing.Size(120, 450);
            this.GenresBooks.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cartesianSaleBook);
            this.panel1.Location = new System.Drawing.Point(124, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 446);
            this.panel1.TabIndex = 1;
     
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChartRevenue);
            this.panel2.Location = new System.Drawing.Point(436, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 253);
            this.panel2.TabIndex = 1;
            // 
            // pieChartRevenue
            // 
            this.pieChartRevenue.Location = new System.Drawing.Point(3, 3);
            this.pieChartRevenue.Name = "pieChartRevenue";
            this.pieChartRevenue.Size = new System.Drawing.Size(232, 247);
            this.pieChartRevenue.TabIndex = 0;
            this.pieChartRevenue.Text = "pieChart1";
            // 
            // cartesianSaleBook
            // 
            this.cartesianSaleBook.Location = new System.Drawing.Point(8, 13);
            this.cartesianSaleBook.Name = "cartesianSaleBook";
            this.cartesianSaleBook.Size = new System.Drawing.Size(423, 412);
            this.cartesianSaleBook.TabIndex = 0;
            this.cartesianSaleBook.Text = "cartesianChart1";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenresBooks);
            this.Name = "Chart";
            this.Text = "ChartBook";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GenresBooks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LiveCharts.WinForms.PieChart pieChartRevenue;
        private LiveCharts.WinForms.CartesianChart cartesianSaleBook;
    }
}

