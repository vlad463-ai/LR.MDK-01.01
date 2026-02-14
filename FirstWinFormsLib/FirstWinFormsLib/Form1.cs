using ModelViewLib.Models;
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
        UsersTableView usersTable_ = new UsersTableView();
        public MainForm()
        {
            InitializeComponent();
            
            Controls.Add(usersTable_);
            usersTable_.Dock = DockStyle.Top;
            usersTable_.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UserPresenter UserPres = new UserPresenter(new MemoryUsersModels(), usersTable_);
        }

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
             
        }
    }
}
