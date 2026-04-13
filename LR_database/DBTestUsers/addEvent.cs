using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestUsers
{
    public partial class addEvent: Form
    {
        private SporEvent editingEvent;
        PgPlacesLoader loader_;
        public addEvent(PgPlacesLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        private void OKButt_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(placeTextBox.Text)
               || string.IsNullOrWhiteSpace(responsibleTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }
            
            SporEvent events = new SporEvent
            {
                Place = placeTextBox.Text,
                Date = dateTextBox.Text,
                Price = (int)priceNumericUpDown.Value,
                Responsible = responsibleTextBox.Text,
            };
            loader_.AddEvent(events);
            this.Close();
        }

        private void CancelButt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyButt_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(placeTextBox.Text)
                || string.IsNullOrWhiteSpace(responsibleTextBox.Text))
            {
                MessageBox.Show("Не все обязательные поля были заполнены!", "Внимание");
                return;
            }

            SporEvent events = new SporEvent
            {
                Place = placeTextBox.Text,
                Date = dateTextBox.Text,
                Price = (int)priceNumericUpDown.Value,
                Responsible = responsibleTextBox.Text,
            };
            loader_.AddEvent(events);
            this.Close();

        }

        public void SetEvent(SporEvent events)
        {
            editingEvent = events;
            placeTextBox.Text = events.Place;
            dateTextBox.Text = events.Date;
            priceNumericUpDown.Value = events.Price;
            responsibleTextBox.Text = events.Responsible;

        }
        
    }
}
