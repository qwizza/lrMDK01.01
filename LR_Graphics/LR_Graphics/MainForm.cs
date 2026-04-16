using GraphicsLib;
using GraphicsLib.Presenter;
using GraphicsLib.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace LR_Graphics
{
    public partial class MainForm : Form
    {
        private SalePresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new SalePresenter(new List<ISaleView> { saleCartesianChart });
            listBoxItems.DataSource = _presenter.GetAllItems();
            listBoxItems.DisplayMember = "Name";
            salePieChart.UpdateData(_presenter);
            if (listBoxItems.Items.Count > 0)
            {
                listBoxItems.SelectedIndex = 0;
            }
        }
        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedItem is Item selected)
            {
                _presenter.SelectedItemChanged(selected.Name);
            }
        }

        
    }
}
