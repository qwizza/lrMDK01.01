using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenters;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MainForm : Form
    {
        UserPresenter presenter_;
        IUsersModel model_ = new MemoryUsersModel();
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new UserPresenter(new MemoryUsersModel(), usersTableView1);           
        }
        private void toolStrip1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователей?",
                            "Внимание",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question)
                             == DialogResult.Yes)
            {
                List<User> selectedUser = usersTableView1.GetSelectedUsers();
                presenter_.RemoveUsers(selectedUser);
            } 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            if(addUser.ShowDialog() == DialogResult.OK)
            {
                presenter_.AddUser(addUser.user);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
           
        }
    }
}
