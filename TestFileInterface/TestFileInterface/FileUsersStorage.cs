

using System.Collections.Generic;
using System.IO;
using System.Web.UI.MobileControls.Adapters;

namespace TestFileInterface
{
    public class FileUsersStorage : IUserInterface
    {
        string line;
        public List<User> Load()
        {
            List<User> allUsers = new List<User>();
            string path = "MyPassword.txt";
            StreamReader reader = new StreamReader(path);
            string line;
            while ((line =  reader.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                allUsers.Add(new User(lines[0], lines[1]));
            }
            return allUsers;
            
        }



    }
}
