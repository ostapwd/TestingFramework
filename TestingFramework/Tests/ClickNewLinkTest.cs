using System;
using System.Threading;
using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.TestData;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    public class ClickNewLinkTest : BaseTest
    {
        private TellUsPage tellUsPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            tellUsPage = StartPage.OpenLoginPage()
                .Login(UserData.User)
                .OpenMyEbayPage().OpenMessagesPage().OpenTellUsPage();
        }

        [Test]
        public void ClickNewLink()
        {
            Thread.Sleep(20000);
            Assert.AreEqual(Driver.Get().Url, "http://connect.ebay.com/srv/survey/a/m2m.mmi",
                "Wrong URL in the browser");

            Assert.IsTrue(tellUsPage.IsSendButtonShown(), 
               "'Tell us what you think' page should be shown");
        }
    }
}
