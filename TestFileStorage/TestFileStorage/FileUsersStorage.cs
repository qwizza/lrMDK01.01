using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class FileUsersStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            using (StreamReader reader = new StreamReader("C:\\Users\\zhesmik\\source\\repos\\lrMDK01.01\\TestFileStorage\\TestFileStorage.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] userInfo = line.Split('-');
                    User user = new User(userInfo[0], userInfo[1]);
                    result.Add(user);
                }
            }
            return result;
        }
    }
}
