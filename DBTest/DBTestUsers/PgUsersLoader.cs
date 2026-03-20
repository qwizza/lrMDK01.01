using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestUsers
{
   public class PgUsersLoader
   {
        private const string connectSetting = "Host=192.168.1.48;Username=st50-11;Password=5011;Database=MDK01.01Ryzhov";
        public List<User> Load()
        {
            try
            {

                List<User> result = new List<User>();
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, age, name, surname From myusers;";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Age = reader.GetInt32(2),
                        Name = reader.GetString(3),
                        Surname = reader.GetString(4),
                    };
                    result.Add(user);
                }
                return result;
            }
            catch (NpgsqlException execute)
            {
                MessageBox.Show($"Ошибка: {execute.Message}");

                return null;
            }
        }
        public bool DeleteUser(string Login)
        {
            try
            {
                bool result = true;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"DELETE FROM myusers WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery(); 
                if (execute > 0)
                {
                    result = true;
                }

                return result;

            }
            catch(NpgsqlException execute)
            {
                MessageBox.Show($"Ошибка: {execute.Message}");

                return false;
            }
            
        }
   }
}
