using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.TestData;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class LoginNegativeTest : BaseTest
    {
        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {   
            StartPage.OpenLoginPage();
            _loginPage = new LoginPage();

            Screenshot.Take("Screen1.jpg");
        }
  
        [Test]
        public void NegativeLoginTest()
        {
            _loginPage.LoginNegative(UserData.InvalidLogin, UserData.InvalidPassword);
            LoginPageNegative loginPageNegative = new LoginPageNegative();

            bool isElementShown = loginPageNegative.IsErrorLabelShown();
            string elementInnerText = loginPageNegative.GetErrorLabelText();

            Screenshot.Take("Screen2.jpg");

            Assert.IsTrue(isElementShown, "Error message should be shown!");
            Assert.AreEqual( "Oops, that's not a match!", elementInnerText);
        }
    }
}
