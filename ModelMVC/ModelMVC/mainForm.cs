using ModelViewLib.Models;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelMVC
{
    public partial class mainForm: Form
    {
        public mainForm()
        {
            InitializeComponent();

            UsersTabeView tableView = new UsersTabeView();
            Controls.Add(tableView);
            tableView.Dock = DockStyle.Top;
            UserPresenter user = new UserPresenter(new MemioryUsersModel(), tableView);
        }
    }
}
