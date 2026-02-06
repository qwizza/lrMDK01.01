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

namespace WindowsFormsApp1
{
    public partial class Number : Form
    {
        int timeLeft = 30; 
        Timer timer;
        int NextRun_;
        public Number()
        {
            InitializeComponent();

            dateTimePicker.Value = DateTime.Today.AddSeconds(30);

            
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += dateTimePicker_ValueChanged;
            timer.Start();

            Random random = new Random();
            NextRun_ = random.Next(1, 101);
        }

        private void Check(object sender, EventArgs e)
        {
            int anInteger = Convert.ToInt32(Text.Text);

            if (NextRun_ > anInteger)
            {
                MessageBox.Show("Введеное число меньше!");
            }
            else if (NextRun_ < anInteger) 
            {
                MessageBox.Show("Введеное число больше!");
            }
            else
            {
                MessageBox.Show("Вы угадали!");
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timeLeft--; 

            dateTimePicker.Value = DateTime.Today.AddSeconds(timeLeft);

            if (timeLeft <= 0)
            {
                timer.Stop();
                MessageBox.Show("Время вышло!");
            }
        }
    }
}
