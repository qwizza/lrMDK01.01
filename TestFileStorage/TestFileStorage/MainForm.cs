using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm : Form
    {
        private List<User> users = new List<User>();
        private FileUsersStorage fileUsersStorage = new FileUsersStorage();
        public MainForm()
        {
            InitializeComponent();
            LoadUserLogins();
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (LoginComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя!");
                return;
            }                      
            string selectedLogin = LoginComboBox.SelectedItem.ToString();
            User selectedUser = users.Find(u => u.Login == selectedLogin);
            if (selectedUser != null)
            {
                if (PasswordTextBox.Text == selectedUser.Password)
                {
                    MessageBox.Show("Пароль введен верно :)");
                }
                else
                {
                    MessageBox.Show("Пароль введен неверно :(");
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!");
            }
        }
        public void LoadUserLogins()
        {
            users = fileUsersStorage.Load();
            LoginComboBox.Items.Clear();
            foreach (User user in users)
            {
                LoginComboBox.Items.Add(user.Login);
            }
            if (LoginComboBox.Items.Count > 0)
            {
                LoginComboBox.SelectedIndex = 0;
            }
        }

    }
}
