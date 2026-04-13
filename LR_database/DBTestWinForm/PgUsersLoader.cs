using Npgsql;
using System.ComponentModel;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        private const string connectSetting = "Host=192.168.1.48;Username=st50-6;Password=506;Database=Test";
        private BindingList<User> allUsers_ = new BindingList<User>();
        public BindingList<User> Load() 
        {
            try
            {                
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password, name, age  From quarty";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        Age = reader.GetInt32(3)
                    };
                    allUsers_.Add(user);
                }
                return allUsers_;
            }
            catch(NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        } 
        
        public bool DeleteSelectedUser(string Login)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM quarty Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", Login);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < allUsers_.Count; i++)
                    {
                        if (allUsers_[i].Login == Login)
                        {
                            allUsers_.RemoveAt(i);
                            i--;
                        }
                    }
                }                              
                return result;
            }
            catch(NpgsqlException exception) 
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }

        public bool ClearUser()
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM quarty";
                var cmd = new NpgsqlCommand(sql, con);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allUsers_.Clear();
                }                
                return result;                
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool AddUser(User u)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO quarty(login, password, name, age) VALUES (@login, @password, @name, @age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@age", u.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    allUsers_.Add(u);
                }                
                return result;
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }

        }

        public bool EditUser(User u)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE quarty SET password = @password, name = @name, age = @age Where login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", u.Login);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@age", u.Age);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < allUsers_.Count; i++)
                    {
                        if (allUsers_[i].Login == u.Login)
                        {
                            allUsers_[i].Login = u.Login;
                            allUsers_[i].Password = u.Password;
                            allUsers_[i].Name = u.Name;
                            allUsers_[i].Age = u.Age;

                        }
                    }
                }
                return result;
            }

            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
    }
}
