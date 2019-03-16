namespace TestingFramework.TestData
{
    public static class UserData
    {
        public static string Login = "ostapwdwdwd@gmail.com";
        public static string Password = "fR7Hsj2k!kkd3";

        public static string InvalidLogin = "ostapwd123@gmail.com";
        public static string InvalidPassword = "fR7ggg2k!kkd3";

        public static UserModel User = new UserModel(Login, Password);
        public static UserModel InvalidUser = new UserModel(InvalidLogin, "fsdfsdfsdf");
    }
}
