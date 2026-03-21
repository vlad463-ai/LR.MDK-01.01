using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBTestWinForm
{
    public class PgUsersLoader
    {
        private BindingList<User> result_ = new BindingList<User>();
        private const string connectSetting = "Host=192.168.1.48;Username=st50-7;Password=507;Database=Test";
        public BindingList<User> Load() 
        {
            try
            {
                
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT login, password,name, age  From quarty";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        Age = reader.GetInt32(3),
                      
                        
                    };
                    result_.Add(user);
                }
                return result_;
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
                    
                }
                for(int i = 0; i<result_.Count;i++)
                {
                    if (result_[i].Login == Login)
                    {
                        result_.RemoveAt(i);
                        i--;
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

            }
            result_.Clear();
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
            var sql = "Insert INTO quarty(login, password,name, age) VALUES(@login, @password, @name, @age)";
            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@login", u.Login);
            cmd.Parameters.AddWithValue("@password", u.Password);
            cmd.Parameters.AddWithValue("@name", u.Name);
            cmd.Parameters.AddWithValue("@age", u.Age);
            int execute = cmd.ExecuteNonQuery();
            if (execute > 0)
            {
                result = true;
                result_.Add(u);
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
