using System;
using NUnit.Framework;
using TestingFramework.Pages;

namespace TestingFramework.Tests
{
    class ClickNewLinkTest : BaseTest
    {

        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            StartPage.OpenLoginPage();
            _loginPage = new LoginPage();
        }

        [Test]
        public void ClickNewLink()
        {
            HomePage homePage = _loginPage.Login(TestData.UserData.User);

            homePage.OpenMyEbayPage().OpenMessagesPage().OpenTellUsPage();

            //Console.Read();
            //bool isElementShown = homePage.IsSearchStringShown();           
            //Assert.IsTrue(isElementShown, "Element should be shown!");
        }
    }
}
