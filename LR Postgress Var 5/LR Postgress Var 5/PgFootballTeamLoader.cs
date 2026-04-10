using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace LR_Postgress_Var_5
{
    public class PgFootballTeamLoader
    {
        private BindingList<FootballTeam> result_ = new BindingList<FootballTeam>();
        private const string connectSetting = "Host=192.168.1.48;Username=st53-5;Password=535;Database=footballTeam";
        public BindingList<FootballTeam> Load()
        {
            try
            {

                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "SELECT fio,game_number ,number_of_goals_scored,number_of_gears   From football_team";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FootballTeam user = new FootballTeam
                    {
                        Fio = reader.GetString(0),
                        GameNumber = reader.GetInt32(1),
                        NumberOfGoalsScored = reader.GetInt32(2),
                        NumberOfGears = reader.GetInt32(3),


                    };
                    result_.Add(user);
                }
                return result_;
            }
            catch (NpgsqlException exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
                return null;
            }
        }
        public bool DeleteSelectedUser(string Fio)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "DELETE FROM football_team Where fio = @fio";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fio", Fio);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;

                }
                for (int i = 0; i < result_.Count; i++)
                {
                    if (result_[i].Fio == Fio)
                    {
                        result_.RemoveAt(i);
                        i--;
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
        public bool AddUser(FootballTeam u)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "Insert INTO football_team(fio,game_number ,number_of_goals_scored,number_of_gears) VALUES(@fio,@game_number ,@number_of_goals_scored,@number_of_gears)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fio", u.Fio);
                cmd.Parameters.AddWithValue("@game_number", u.GameNumber);
                cmd.Parameters.AddWithValue("@number_of_goals_scored", u.NumberOfGoalsScored);
                cmd.Parameters.AddWithValue("@number_of_gears", u.NumberOfGears);
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
        public bool EditUser(FootballTeam u)
        {
            try
            {
                bool result = false;
                var con = new NpgsqlConnection(connectSetting);
                con.Open();
                var sql = "UPDATE football_team Set fio = @fio, game_number = @game_number, number_of_goals_scored = @number_of_goals_scored WHERE number_of_gears = @number_of_gears";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fio", u.Fio);
                cmd.Parameters.AddWithValue("@game_number", u.GameNumber);
                cmd.Parameters.AddWithValue("@number_of_goals_scored", u.NumberOfGoalsScored);
                cmd.Parameters.AddWithValue("@number_of_gears", u.NumberOfGears);
                int execute = cmd.ExecuteNonQuery();
                if (execute > 0)
                {
                    result = true;
                    for (int i = 0; i < result_.Count; i++)
                    {
                        if (result_[i].Fio == u.Fio)
                        {
                            result_[i] = u;
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
