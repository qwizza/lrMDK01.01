using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemioryUsersModel : IusersModel
    {
        private List<User> users_ = new List<User>();
        public List<User> LoadUsers()
        {
            return users_;
        }

        public bool Register(User user)
        {
            int CountList = users_.Count();
            users_.Add(user);
            return CountList < users_.Count();
        }
        public MemioryUsersModel()
        {
            users_.Add(new User("Василий", "123", "Vasya"));
            users_.Add(new User("Максим", "456", "Max"));
            users_.Add(new User("Никита", "789", "Nekit"));
        }
    }
}
