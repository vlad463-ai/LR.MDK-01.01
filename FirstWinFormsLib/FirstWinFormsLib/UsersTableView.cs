using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsLib
{
    public class UsersTableView : DataGridView, IUsersViews
    {
        public List<User> GetSelectedUser()
        {
            List<User> result = new List<User>();
            foreach(var row in SelectedRows)
            {
                result.Add(row as User);
            }
            return result;
        }

        public void Show(List<User> allUsers)
        {
           DataSource = allUsers;
        }
    }
}
