using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsClassWork
{
    class Student
    {
        private string name_;
        private int age_;
        private double avg_;
        private int ticketNumber_;
        private string imagePath_;


        public Student(string name, int age, double avg, int ticketNumber, string imagePath)
        {
            name_ = name;
            age_ = age;
            avg_ = avg;
            ticketNumber_ = ticketNumber;
            imagePath_  = imagePath;
        }

        public string Name
        {
            get { return name_; }
        }

        public int Age
        {
            get { return age_; }
        }

        public double Avg
        {
            get { return avg_; }
        }

        public int TicketNumber
        {
            get { return ticketNumber_; }
        }

        public string imagePath
        {
            get { return imagePath_; }
        }
    }
}
