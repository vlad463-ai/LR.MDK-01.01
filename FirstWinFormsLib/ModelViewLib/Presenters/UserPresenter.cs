using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Presenters
{
    public class UserPresenter
    {
        private IUsersModel model_;
        private IUsersViews view_;
        private List<User> user_ = new List<User>();

        public UserPresenter (IUsersModel model, IUsersViews view)
        {
            model_ = model;
            view_ = view;
            user_ = model.Load();
            view_.Show(user_);
        }

        public void RemoveUser(List<User> selectedUser)
        {
            model_.RemoveUsers(selectedUser);
            view_.Show(model_.Load());
        }
        public void AddUser(User U)
        {
            
            model_.AddUser(U); 
            view_.Show(model_.Load());
        }
    }
}
