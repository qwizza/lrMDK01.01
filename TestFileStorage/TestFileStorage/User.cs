namespace TestFileStorage
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
        public string Login
        {
            get { return login_; }
        }
        public string Password 
        {
            get { return password_; }
        }
        public void SetLogin(string login) 
        {
            login_ = login;
        }
        public void SetPassword(string password)
        {
            password_ = password;
        }

    }
}
