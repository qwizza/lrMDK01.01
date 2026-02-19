using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUsersModel : IUsersModel
    {
        private List<User> users_ = new List<User>();
        public MemoryUsersModel() 
        {
            users_.Add(new User ("Autumn","123","Осень"));
            users_.Add(new User("Winter", "456", "Зима"));
            users_.Add(new User("Spring", "789", "Весна"));
            users_.Add(new User("Summer", "012", "Лето"));
        }
        public List<User> LoadData()
        {
            return users_;
        }

        public bool RegUser(User user)
        {
            int count = users_.Count;
            users_.Add(user);
            if (users_.Count == count + 1)
            {
                return true;
            }
            return false;
        }
        public void RemoveUsers(List<User> users)
        {
            foreach (User user in users)
            { 
                int targetIndex = users_.FindIndex(local => local.Login ==  user.Login);
                if (targetIndex >= 0) 
                {
                    users_.RemoveAt(targetIndex);
                }
            }
        }
    }
}
