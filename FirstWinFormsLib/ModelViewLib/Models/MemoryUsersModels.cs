using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public class MemoryUsersModels : IUsersModel
    {
        private List<User> allUsers_ = new List<User>();
        public MemoryUsersModels()
        {
            allUsers_.Add(new User("Max100500", "bebebebe123", "Максимка"));
            allUsers_.Add(new User("Max500100", "ebebeb321", "Никитака"));
        }

        public List<User> Load()
        {
            return allUsers_;
        }

        public bool Register(User user)
        {
            int count = allUsers_.Count;
            allUsers_.Add(user);
            if (allUsers_.Count> count)
            {
                return true;
            }
            return false;
        }

        public void RemoveUsers(List<User> users)
        {
            foreach(User u in users)
            {
                int targetIndex = allUsers_.FindIndex(local => local.Login == u.Login);
                if (targetIndex >= 0)
                {
                    allUsers_.RemoveAt(targetIndex);
                }
            }
        }
    }
}
