using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestingFramework.Pages;
using TestingFramework.TestData;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    class FeedbackTest : BaseTest
    {
        private LoginPage _loginPage;
        private HomePage _homepage;
        private MyEbayPage _myEbayPage;
        private MesgEbayPage _mesgEbayPage;
        private FeedbackFormPage _feedbackFormPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            //StartPage.OpenLoginPage();
            //_loginPage = new LoginPage();
        }

        [Test]
        public void ReachFeedbackPageTest()
        {
            string expectedUrl = "http://connect.ebay.com/srv/survey/a/m2m.mmi";
            StartPage.OpenLoginPage()
                  .Login(TestData.UserData.Login, TestData.UserData.Password)
                  .OpenMyEbayPage()
                  .OpenMessagesPage()
                  .ReachFeedbackForm();

           string currentUrl = Driver.Get().Url;
           Assert.AreEqual(expectedUrl, currentUrl);
        
        }

        [Test]
        public void CheckAllMessagesWithMasterCheckboxTest()
        {
           var _mesgEbayPage = StartPage.OpenLoginPage()
                  .Login(TestData.UserData.Login, TestData.UserData.Password)
                  .OpenMyEbayPage()
                  .OpenMessagesPage();
            _mesgEbayPage.SelectAllChecked.Check();


        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(10000);
        }
    }
}
