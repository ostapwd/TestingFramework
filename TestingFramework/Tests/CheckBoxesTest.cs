using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using TestingFramework.CustomWebElements;
using TestingFramework.Pages;
using TestingFramework.TestData;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    public class CheckBoxesTest : BaseTest
    {
        private MessagesPage messagesPage;
        private SoftAssert _softAssert = null;

        [OneTimeSetUp]
        public void OpenMessagesPage()
        {
            _softAssert = new SoftAssert();

            messagesPage = StartPage.OpenLoginPage()
                .Login(UserData.User)
                .OpenMyEbayPage().OpenMessagesPage();
        }

        [Test]
        public void VerifySelectCheckBoxesInTable()
        {
            Wait.Time(TimeSpan.FromSeconds(5));

            messagesPage.CheckAll.Check();

            //List<CheckBox> cbList = messagesPage.GetAllTableCheckBoxes();
            
            foreach (var result in messagesPage.GetAllTableCheckBoxes())
            {
                _softAssert.IsTrue(result.IsSelected(), "Checkbox is not selected. Should be selected.");
            }

            _softAssert.AssertAll();

        }
        [Test]
        public void VerifyUnSelectCheckBoxesInTable()
        {
            Wait.Time(TimeSpan.FromSeconds(5));

            messagesPage.CheckAll.UnCheck();

            foreach (var result in messagesPage.GetAllTableCheckBoxes())
            {
                _softAssert.IsFalse(result.IsSelected(), "Checkbox is selected. Should be unselected.");
            }
            
            _softAssert.AssertAll();

        }
    }
}

