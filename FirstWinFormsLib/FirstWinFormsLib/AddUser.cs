using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsLib
{
    public partial class AddUser: Form
    {
        MemoryUsersModels userModels_;
        private User user_;
        public User user
        {
            get { return user_; }
            set { user_ = value; }
        }
        public AddUser()
        {
            InitializeComponent();
            userModels_ = new MemoryUsersModels();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<User> allUsers_ = new List<User>();
            user = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
        }
    }
}
