//using NUnit.Framework;
//using TestingFramework.Pages;
//using TestingFramework.TestData;
//namespace TestingFramework.Tests
//{
//    [TestFixture]
//    [Parallelizable(ParallelScope.Fixtures)]

//    class FeedbackTest: BaseTest
//    {
//        private LoginPage _loginPage;

//        [OneTimeSetUp]
//        public void OpenLoginPage()
//        {
//           StartPage.OpenLoginPage();
//            _loginPage = new LoginPage();
//        }
//        public FeedbackTest()
//        {
//            HomePage homePage = _loginPage.Login(UserData.User);

//        }
//    }
//}
