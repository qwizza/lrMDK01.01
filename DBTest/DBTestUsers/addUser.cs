using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestUsers
{
    public partial class addUser: Form
    {
        private User editingUser;
        PgUsersLoader loader_;
        public addUser(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        private void OKButt_Click_1(object sender, EventArgs e)
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
                Surname = surnameTextBox.Text
            };
            loader_.AddUser(user);
            this.Close();
        }

        private void CancelButt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButt_Click_1(object sender, EventArgs e)
        {
            editingUser.Login = loginTextBox.Text;
            editingUser.Password = passwordTextBox.Text;
            editingUser.Age = (int)ageNumericUpDown.Value;
            editingUser.Name = nameTextBox.Text;
            editingUser.Surname = surnameTextBox.Text;

            bool success = loader_.EditUser(editingUser);

            if (success)
            {
                MessageBox.Show("Данные обновлены!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка при обновлении данных!");
            }
        }
        public void SetUser(User user)
        {
            editingUser = user;
            loginTextBox.Text = user.Login;
            passwordTextBox.Text = user.Password;
            ageNumericUpDown.Value = user.Age;
            nameTextBox.Text = user.Name;
            surnameTextBox.Text = user.Surname;
        }
    }
}
