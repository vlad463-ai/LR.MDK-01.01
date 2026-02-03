

namespace TestFileInterface
{
    public class User
    {
        private string login_;
        private string password_;
        public User(string login, string password)
        {
            login_ = login;
            password_ = password;
        }
        public string Password
        {
            get { return password_; }
        }
        public string Login
        {
            get { return login_; }
        }

    }
    
}
