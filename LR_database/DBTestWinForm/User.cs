using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTestWinForm
{
    public class User : INotifyPropertyChanged
    {
        public string login_;
        public string password_;
        public string name_;
        public int age_;
        [DisplayName("Логин")]
        public string Login 
        {
            get 
            { 
                return login_;
            }
            set 
            {
                login_ = value; 
                OnPropertyChanged(nameof(login_));
            }
        }
        [DisplayName("Пароль")]
        public string Password
        {
            get
            {
                return password_;
            }
            set 
            {
                password_ = value;
                OnPropertyChanged(nameof(password_));
            }
        }
        [DisplayName("Имя")]
        public string Name
        {
            get 
            {
                return name_;
            }
            set 
            {
                name_ = value;
                OnPropertyChanged(nameof(name_));
            }
        }
        [DisplayName("Возраст")]
        public int Age
        {
            get
            {
                return age_;
            }
            set
            {
                age_ = value;
                OnPropertyChanged(nameof(age_));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
