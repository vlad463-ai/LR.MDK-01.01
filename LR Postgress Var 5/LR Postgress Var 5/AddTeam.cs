using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_Postgress_Var_5
{
    public partial class AddTeam : Form
    {
        private PgFootballTeamLoader loader_;

        private bool editMode_ = false;
        public AddTeam(PgFootballTeamLoader loader)
        {
            InitializeComponent();
          
            loader_ = loader;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                FootballTeam fio = new FootballTeam()
                {
                    Fio = login.Text,
                    GameNumber = Convert.ToInt32(password.Text),
                    NumberOfGoalsScored = Convert.ToInt32(name.Text),
                    NumberOfGears =(int)age.Value

                };
                loader_.EditUser(fio);
            }
            else
            {
                FootballTeam fio = new FootballTeam()
                {
                    Fio = login.Text,
                    GameNumber = Convert.ToInt32(password.Text),
                    NumberOfGoalsScored = Convert.ToInt32(name.Text),
                    NumberOfGears = (int)age.Value

                };
                loader_.AddUser(fio);
            }
            this.Close();
        }
        public void SetUser(FootballTeam u)
        {
            login.Text = u.Fio;
            password.Text = u.GameNumber.ToString();
            name.Text = u.NumberOfGoalsScored.ToString();
            age.Value = u.NumberOfGears;
            login.Enabled = false;
            editMode_ = true;
        }

    }
}
