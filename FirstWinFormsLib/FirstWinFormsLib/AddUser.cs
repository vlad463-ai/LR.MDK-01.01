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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstWinFormsLib
{
    public partial class AddUser: Form
    {
     
        private User user_;
        public User user
        {
            get { return user_; }
        }
        public AddUser()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Trim() != "" && PasswordTextBox.Text.Trim() != "" && NameTextBox.Text.Trim() != "")
            {
                DialogResult = DialogResult.Yes;
                user_ = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
            }
            else
            {
                MessageBox.Show("Введите корректные данные !!! :)");
                DialogResult = DialogResult.No;
            }  
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
