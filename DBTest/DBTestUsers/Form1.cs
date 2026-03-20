using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DBTestUsers
{
    public partial class Form1: Form
    {
            PgUsersLoader loader = new PgUsersLoader();
        public Form1()
        {
            InitializeComponent();
            List<User> users = loader.Load();
            dataGridView.DataSource = users;
        }

        private void deleteButt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader.DeleteUser(user.Login);
        }
    }
}
