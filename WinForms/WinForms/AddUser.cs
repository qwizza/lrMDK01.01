using ModelViewLib.ModelViews;
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
    public partial class AddUser: Form
    {
    public User user { get; set; }
        public AddUser()
        {
            InitializeComponent();

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            user = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void ClousButten_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
