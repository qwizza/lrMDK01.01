using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestUsers
{
   public class PgUsersLoader
   {
        BindingList<User> loader = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-11;Password=5011;Database=MDK01.01Ryzhov";
        public BindingList <User> Load()
        {
            try
            {
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
                    loader.Add(user);
                }
                return loader;
            }
            catch (NpgsqlException execute)
            {
                MessageBox.Show($"Ошибка: {execute.Message}");

                return null;
            }
        }
        public bool ClearUser()
        {
            try
            {
                bool result = true;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"DELETE FROM myusers";
                var cmd = new NpgsqlCommand(sql, con);
                int execute = cmd.ExecuteNonQuery();
                loader.Clear();
                return execute > 0;
            }
            catch (NpgsqlException execute)
            {
                MessageBox.Show($"Ошибка: {execute.Message}");

                return false;
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
                    for (int i = 0; i < loader.Count; i++)
                    {
                        if (loader[i].Login == Login)
                        {
                            loader.RemoveAt(i);
                            i--;
                            
                        }
                    }
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
