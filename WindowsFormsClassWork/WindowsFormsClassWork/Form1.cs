using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClassWork
{
    public partial class MainForms: Form
    {
        private List<Student> ListStudent_ = new List<Student>();
        public MainForms()
        {
            InitializeComponent();

            ListStudent_.Add ( new Student("Рыжов Арсений", 18, 4.5, 1, "C:\\repos\\WindowsFormsClassWork\\person2.jpg"));
            ListStudent_.Add ( new Student("Кувалдаев Вадим", 18, 4.5, 2, "C:\\repos\\WindowsFormsClassWork\\person1.jpg"));
            ListStudent_.Add ( new Student("Морозов Артем", 18, 4.5, 3, "C:\\repos\\WindowsFormsClassWork\\person3.jpg"));

            studiontListBox.DataSource = ListStudent_;
            studiontListBox.DisplayMember = "Name";

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student st = (Student)studiontListBox.SelectedItem;
            nameLabel.Text = st.Name;
            ageLabel.Text = st.Age.ToString();
            avgLabel.Text = st.Avg.ToString();
            ticketnumberLabel.Text = st.TicketNumber.ToString();
            imagePath.Load(st.imagePath);
        }

        
    }
}
