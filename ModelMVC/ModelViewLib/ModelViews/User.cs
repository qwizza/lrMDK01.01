namespace ModelViewLib.ModelViews
{
    public class User
    {
        private string login_;
        private string password_;
        private string name_;

        public User(string login, string password, string name)
        {
            login_ = login;
            password_ = password;
            name_ = name;
        }
        public string Name
        {
            get { return name_; }
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
