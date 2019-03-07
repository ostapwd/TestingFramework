using System;
using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    public class LoginNegativeTest
    {
        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            Browser.OpenStartPage();

            StartPage startPage = new StartPage();
            startPage.OpenLoginPage();

            _loginPage = new LoginPage();
        }

        [Test]
        public void NegativeLoginTest()
        {
            _loginPage.LoginNegative("werwerwed@gmail.com", "wrongPassword");
            LoginPageNegative loginPageNegative = new LoginPageNegative();

            bool isElementShown = loginPageNegative.IsErrorLabelShown();
            string elementInnerText = loginPageNegative.GetErrorLabelText();

            Assert.IsTrue(isElementShown, "Error message should be shown!");
            Assert.AreEqual( "Oops, that's not a match!", elementInnerText);


            Console.WriteLine(isElementShown);
            Console.WriteLine(elementInnerText);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            Browser.GetDriver().Quit();
        }

    }
}
