using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.TestData;

namespace TestingFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    class LoginPositiveTest : BaseTest
    {
        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            StartPage.OpenLoginPage();
            _loginPage = new LoginPage();
        }

        [Test]
        public void PositiveLoginTest()
        {
            HomePage homePage =_loginPage.Login(UserData.User);
            bool isElementShown = homePage.IsSearchStringShown();

            Assert.IsTrue(isElementShown, "Element should be shown!");
        }
    }
}
