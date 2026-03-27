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
            BindingList<User> users = loader.Load();
            dataGridView.DataSource = users;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void deleteButt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader.DeleteUser(user.Login);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            loader.ClearUser();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            addUser addUser = new addUser(loader);
            addUser.Show();
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            addUser addEditUser = new addUser(loader);
            addEditUser.SetUser(user);
            addEditUser.Show();
        }

    }
}
