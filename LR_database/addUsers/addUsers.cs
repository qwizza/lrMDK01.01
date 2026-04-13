using DBTestUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addUsers
{
    public partial class addUsers: Form
    {
        PgUsersLoader loader_;
        public addUsers(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        private void OKButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text)
               || string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            if (ageNumericUpDown.Value <= 0)
            {
                MessageBox.Show("Возраст не может быть меньше 0");
                return;
            }
            User user = new User
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                Age = (int)ageNumericUpDown.Value,
                Name = nameTextBox.Text,
            };
            loader_.AddUser(user);
            this.Close();
        }

        private void CancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButt_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                Age = (int)ageNumericUpDown.Value,
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text
            };
            loader_.AddUser(user);
        }
    }
}
