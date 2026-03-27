using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBTestUsers
{
    public class User : INotifyPropertyChanged
    {
        private string login_;
        private string password_;
        private int age_;
        private string name_;
        private string surname_;

        [DisplayName("Логин")]
        public string Login
        {
            get { return login_; }
            set
            {
                login_ = value;
                OnPropertyChanged("login");
            }
        }
        [DisplayName("Пароль")]
        public string Password
        {
            get { return password_; }
            set
            {
                password_ = value;
                OnPropertyChanged("password");
            }
        }
        [DisplayName("Возраст")]
        public int Age
        {
            get { return age_; }
            set
            {
                age_ = value;
                OnPropertyChanged("age");
            }
        }
        [DisplayName("Имя")]
        public string Name
        {
            get { return name_; }
            set
            {
                name_ = value;
                OnPropertyChanged("name");
            }
        }
        [DisplayName("Фамилия")]
        public string Surname
        {
            get { return surname_; }
            set
            {
                surname_ = value;
                OnPropertyChanged("surname");
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
