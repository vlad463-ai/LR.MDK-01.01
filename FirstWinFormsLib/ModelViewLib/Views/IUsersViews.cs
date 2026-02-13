using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Views
{
    public interface IUsersViews
    {
        void Show(List<User> allUsers);
    }
}
