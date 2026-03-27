using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTestWinForm
{
    public partial class AddUsers: Form
    {
        private PgUsersLoader loader_;

        private bool editMode_ = false; 

        public AddUsers(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
        }

        public void SetUser(User u)
        {
            login.Text = u.Login;
            password.Text = u.Password;
            name.Text = u.Name;
            age.Value = u.Age;
            login.Enabled = false;
            editMode_ = true;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if(editMode_)
            {
                User user = new User()
                {
                    Login = login.Text,
                    Password = password.Text,
                    Name = name.Text,
                    Age = (int)age.Value

                };
                loader_.EditUser(user);
            }
            else
            {
                User user = new User()
                {
                    Login = login.Text,
                    Password = password.Text,
                    Name = name.Text,
                    Age = (int)age.Value

                };
                loader_.AddUser(user);
            }
                this.Close();


        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Oke_Click(object sender, EventArgs e)
        {
            if (editMode_)
            {
                User user = new User()
                {
                    Login = login.Text,
                    Password = password.Text,
                    Name = name.Text,
                    Age = (int)age.Value

                };
                loader_.EditUser(user);
            }
            else
            {
                User user = new User()
                {
                    Login = login.Text,
                    Password = password.Text,
                    Name = name.Text,
                    Age = (int)age.Value

                };
                loader_.AddUser(user);
            }
            this.Close();
            Oke.Enabled = false;
        }
        
    }
}
