using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private List<MenuGroup> menuGroups;
        private Dictionary<string, List<MenuGroup>> dishesBygroup;
        private Dictionary <Dish,int> orderdDish;
        private Dish currentDish;
        private Dictionary<string, Image> DishImage;

        public MainForm()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
