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
   public class PgPlacesLoader
   {
        BindingList<SporEvent> loader = new BindingList<SporEvent>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-11;Password=5011;Database=LR4Ryzhov";
        public BindingList <SporEvent> Load()
        {
            try
            {
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT place, date, responsible, price From sportevent;";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SporEvent events = new SporEvent
                    {
                        Place = reader.GetString(0),
                        Date = reader.GetString(1),
                        Responsible = reader.GetString(2),
                        Price = reader.GetInt32(3),
                    };
                    loader.Add(events);
                }
                return loader;
            }
            catch (NpgsqlException execute)
            {
                MessageBox.Show($"Ошибка: {execute.Message}");

                return null;
            }
        }
        public bool ClearEvent()
        {
            try
            {
                bool result = true;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"DELETE FROM sportevent";
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
        public bool AddEvent(SporEvent events)
        {
            try
            {
                bool addResult = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "INSERT INTO sportevent(place, date, responsible, price) VALUES(@place, @date, @responsible ,@price)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@place", events.Place);
                cmd.Parameters.AddWithValue("@date", events.Date);
                cmd.Parameters.AddWithValue("@responsible", events.Responsible);
                cmd.Parameters.AddWithValue("@price", events.Price);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    addResult = true;
                    loader.Add(events);
                }
                return addResult;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return false;
            }
        }
        public bool DeleteEvent(string Place)
        {
            try
            {
                bool result = true;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = @"DELETE FROM sportevent WHERE place = @place";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@place", Place);
                int execute = cmd.ExecuteNonQuery(); 
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < loader.Count; i++)
                    {
                        if (loader[i].Place == Place)
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

        public bool EditEvent(SporEvent events)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE sportevent SET date = @date, responsible = @responsible, price = @price WHERE place = @place";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@place", events.Place);
                cmd.Parameters.AddWithValue("@date", events.Date);
                cmd.Parameters.AddWithValue("@responsible", events.Responsible);
                cmd.Parameters.AddWithValue("@price", events.Price);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < loader.Count; i++)
                    {
                        if (loader[i].Place == events.Place)
                        {
                            loader[i].Place = events.Place;
                            loader[i].Date = events.Date;
                            loader[i].Responsible = events.Responsible;
                            loader[i].Price = events.Price;
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
