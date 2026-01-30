using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        private List<MenuGroup> menuGroups = new List<MenuGroup>();
        private Dictionary<string, List<Dish>> dishesByGroup = new Dictionary<string, List<Dish>>();
        private List<OrderItem> currentOrder = new List<OrderItem>();

        public MainForm()
        {
            InitializeComponent();
            InitializeMenuData();
            SetupEventHandlers();
        }
    }
}