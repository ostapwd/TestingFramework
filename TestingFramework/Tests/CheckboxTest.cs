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
    class CheckboxTest : BaseTest
    {
        private SoftAssert _softAssert = null;
        private MesgEbayPage _mesgEbayPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            _mesgEbayPage = StartPage.OpenLoginPage()
                .Login(TestData.UserData.Login, TestData.UserData.Password)
                .OpenMyEbayPage()
                .OpenMessagesPage();
        }

        [SetUp]
        public void SetUp()
        {
             _softAssert = new SoftAssert();
        }

        [Test]
        public void CheckAllMessagesWithMasterCheckboxTest()
        {
            _mesgEbayPage.SelectAllChecked.Check();
            foreach (var checkbox in _mesgEbayPage.RetrieveAllCheckboxes())
            {
                _softAssert.IsTrue(checkbox.IsChecked(), "This checkbox is not checked but should be");
            }
            _softAssert.AssertAll();
        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(10000);
        }
    }
}
