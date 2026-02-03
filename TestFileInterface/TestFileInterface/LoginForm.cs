using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileInterface
{
    public partial class LoginForm: Form
    {
        private FileUsersStorage AllPasswordsAndLogins = new FileUsersStorage();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> men = AllPasswordsAndLogins.Load();
            //string login = 
            string password = TextBoxPassword.Text;
            User user1 = new User(login, password);

            if(Contains(men,user1))
            {
                MessageBox.Show("Все отлично");
            }
            else
            {
                MessageBox.Show("Все плохо");
            }
            
        }
        private bool Contains(List<User> men, User user1)
        {
            foreach(User u in men)
            {
                if (user1.Login == u.Login && user1.Password == u.Password)
                {
                    return true;
                    
                }
                
                
            }
            return false;
        }

        private void LoginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = LoginComboBox.SelectedItem.ToString();
            List<User>
        }
    }
}
