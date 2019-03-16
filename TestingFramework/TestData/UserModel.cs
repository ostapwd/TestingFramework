namespace TestingFramework.TestData
{
    public class UserModel
    {
        public UserModel(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; private set; }

        public string Password { get; private set; }
    }
}
