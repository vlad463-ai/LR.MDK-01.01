using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsLib
{
    public partial class MainForm: Form
    {

        private UserPresenter presenter_;
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new UserPresenter(new MemoryUsersModels(), usersTableView1);
        }

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            List<User> selectedUser = usersTableView1.GetSelectedUser();
            presenter_.RemoveUser(selectedUser);
        }
    }
}
