using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestingFramework.Pages;
using TestingFramework.TestData;

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
            StartPage.OpenLoginPage();
            _loginPage = new LoginPage();
        }

        [Test]
        public void ReachFeedbackPageTest()
        {
            _homepage = _loginPage.Login(TestData.UserData.Login, TestData.UserData.Password);
            _myEbayPage = _homepage.OpenMyEbayPage();
            _mesgEbayPage = _myEbayPage.OpenMessagesPage();
            _feedbackFormPage = _mesgEbayPage.ReachFeedbackForm();
        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(10000);
        }
    }
}
