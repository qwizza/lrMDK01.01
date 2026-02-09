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

namespace GueesTheNumber
{
    public partial class Number : Form
    {
        int NextRun_;
        private int seccondNow_;
        private int attempt_;

        public Number()
        {
            InitializeComponent();
            Random random = new Random();
            NextRun_ = random.Next(1, 101); 
            timer.Start();
            seccondNow_ = 0;
            dateTimePicker.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-seccondNow_);
        }

        private void Check(object sender, EventArgs e)
        {
            attempt_++;
            int anInteger = Convert.ToInt32(TextNumbers.Text);
            if (anInteger == NextRun_)
            {
                timer.Stop();
                MessageBox.Show("Вы угадали!");
                MessangeBoxNumber.AppendText($"Попытка номер: {attempt_}. Ваше число: {TextNumbers.Text}\nВы угадали за {seccondNow_} секунд(ы/у) \n");
            }
            else if (anInteger > NextRun_)
            {
                MessageBox.Show("Загаданное число меньше!");
                MessangeBoxNumber.AppendText($"Попытка номер: {attempt_}. Ваше число: {TextNumbers.Text}. Нужно число меньше \n");
            }
            else if (anInteger < NextRun_)
            {
                MessageBox.Show("Загаданное число больше!");
                MessangeBoxNumber.AppendText($"Попытка номер: {attempt_}. Ваше число: {TextNumbers.Text}. Нужно число больше \n");
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            seccondNow_++;
            dateTimePicker.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-seccondNow_);
            if (seccondNow_ >= 60)
            {
                timer.Stop();
                MessageBox.Show("Ваше время вышло!\n  Вы проиграли!");
                Application.Exit();
            }
        }
    }
}

    