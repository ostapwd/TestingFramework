using System;
using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    
    public class LoginNegativeTest : BaseTest
    {
        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            logs += "\tOneTimeSetUp\n";

            StartPage startPage = new StartPage();
            startPage.OpenLoginPage();
            _loginPage = new LoginPage();

            Screenshot.Take("Screen1.jpg");
        }

        [SetUp]
        public void SetUpTestClass()
        {
            logs += "\t\t\tPrepareEachTest\n";
        }

        [TearDown]
        public void TearDownTestClass()
        {
            logs += "\t\t\tClearAfterEachTest\n";
        }

  
        [Test]
        public void NegativeLoginTest()
        {
            _loginPage.LoginNegative("werwerwed@gmail.com", "wrongPassword");
            LoginPageNegative loginPageNegative = new LoginPageNegative();

            bool isElementShown = loginPageNegative.IsErrorLabelShown();
            string elementInnerText = loginPageNegative.GetErrorLabelText();

            Screenshot.Take("Screen2.jpg");

            Assert.IsTrue(isElementShown, "Error message should be shown!");
            Assert.AreEqual( "Oops, that's not a match!", elementInnerText);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Browser.Close();
        }

    }
}
