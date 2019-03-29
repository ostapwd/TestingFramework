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

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(10000);
        }
    }
}
