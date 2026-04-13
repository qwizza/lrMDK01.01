using System;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddForm: Form
    {
        private PgUsersLoader loader_;
        private bool editMode_ = false;
        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            ApplyButton.Enabled = false;
        }

        public void SetUser(User u)
        {
            LoginTextBox.Text = u.Login;
            LoginTextBox.Enabled = false;
            PasswordTextBox.Text = u.Password;
            NameTextBox.Text = u.Name;
            AgeNumericUpDown.Value = u.Age;
            editMode_ = true;
        }

        public void AddUser()
        {
            loader_.AddUser(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            });
        }

        public void EditUser()
        {
            loader_.AddUser(new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Name = NameTextBox.Text,
                Age = (int)AgeNumericUpDown.Value
            });
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                EditUser();
            }
            else
            {
                AddUser();
            }
                Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                EditUser();
            }
            else
            {
                AddUser();
            }
            ApplyButton.Enabled = false;
        }

        private void AgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyButton.Enabled = true;
        }
    }
}
