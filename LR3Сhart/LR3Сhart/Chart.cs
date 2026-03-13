using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3Сhart
{
    public partial class Chart : Form, IBookSalesView
    {
        private ListBox generesList;
        private CartesianChart cartesianChart;
        private PieChart pieChart;
        private  SalesBookPresenter
        public Chart()
        {
            InitializeComponent();
        }

       
    }
}
