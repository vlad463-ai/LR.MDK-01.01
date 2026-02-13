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
        public MainForm()
        {
            InitializeComponent();
            UsersTableView usersTable = new UsersTableView();
            Controls.Add(usersTable);
            usersTable.Dock = DockStyle.Top;

            UserPresenter UserPres = new UserPresenter(new MemoryUsersModels(), usersTable);
        }
    }
}
