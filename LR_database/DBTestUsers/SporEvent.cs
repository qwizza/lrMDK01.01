using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBTestUsers
{
    public class SporEvent : INotifyPropertyChanged
    {
        private string place_;
        private string date_;
        private string responsible_;
        private int price_;

        [DisplayName("Место проведения")]
        public string Place
        {
            get { return place_; }
            set
            {
                place_ = value;
                OnPropertyChanged("place");
            }
        }
        [DisplayName("Дата и время")]
        public string Date
        {
            get { return date_; }
            set
            {
                date_ = value;
                OnPropertyChanged("date");
            }
        }
        [DisplayName("Ответственный")]
        public string Responsible
        {
            get { return responsible_; }
            set
            {
                responsible_ = value;
                OnPropertyChanged("responsible");
            }
        }
        [DisplayName("Цена")]
        public int Price
        {
            get { return price_; }
            set
            {
                price_ = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
