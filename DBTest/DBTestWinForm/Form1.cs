using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace DBTestWinForm
{
    public partial class MainForm: Form
    {
        PgUsersLoader loader = new PgUsersLoader();
        

        public MainForm()
        {                                              
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<User> users = loader.Load();
            dataGridView.DataSource = users;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView.SelectedRows[0];
            User user = row.DataBoundItem as User;
            loader.DeleteSelectedUser(user.Login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result= MessageBox.Show("Вы действительно хотите все очистить? ","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                loader.ClearUser();
            }
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddUsers addUsers = new AddUsers(loader);
            addUsers.Show();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            User selectedUser = row.DataBoundItem as User;
            AddUsers editUser = new AddUsers(loader);
            editUser.SetUser(selectedUser);
            editUser.Show();
        }
        
    }
}
