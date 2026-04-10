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
    public partial class Form1 : Form
    {
        PgFootballTeamLoader loader = new PgFootballTeamLoader();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<FootballTeam> footballTeam = loader.Load();
            dataGridView1.DataSource = footballTeam;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FootballTeam fio = row.DataBoundItem as FootballTeam;
            loader.DeleteSelectedUser(fio.fio);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddTeam addUsers = new AddTeam(loader);
            addUsers.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FootballTeam selectedUser = row.DataBoundItem as FootballTeam;
            AddTeam editUser = new AddTeam(loader);
            editUser.SetUser(selectedUser);
            editUser.Show();
        }
    }
}
