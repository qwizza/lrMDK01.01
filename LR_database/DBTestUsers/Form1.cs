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
        
        PgPlacesLoader loader = new PgPlacesLoader();
        public Form1()
        {
            InitializeComponent();
            BindingList<SporEvent> events = loader.Load();
            dataGridView.DataSource = events;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void deleteButt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            SporEvent events = row.DataBoundItem as SporEvent;
            loader.DeleteEvent(events.Place);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            loader.ClearEvent();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            addEvent addUser = new addEvent(loader);
            addUser.Show();
        }

        private void EditButt_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            SporEvent events = row.DataBoundItem as SporEvent;
            addEvent addEditUser = new addEvent(loader);
            addEditUser.SetEvent(events);
            addEditUser.Show();
            
        }

    }
}
