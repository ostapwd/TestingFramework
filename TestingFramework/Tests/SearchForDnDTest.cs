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
    [TestFixture]
    class SearchForDnDTest : BaseTest
    {
        private SoftAssert _softAssert = null;
        private LoginPage _loginPage;

        [SetUp]
        public void SetUp()
        {
            _softAssert = new SoftAssert();
        }

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            StartPage.OpenLoginPage();
            _loginPage = new LoginPage();
        }

        [Test]
        public void SearchForDiceTest()
        {
            HomePage homePage = _loginPage.Login(UserData.User);
            Console.WriteLine(StartPage._searchRresults.Count);

            StartPage.CategoriesDropdown.SelectByText("Toys & Hobbies");
            Thread.Sleep(2000);

            StartPage.Search("DnD");

            List<SearchResult> DiceFounded = new List<SearchResult>();
            foreach (var result in StartPage.GetAllSearchResults())
            {
                if (result.GetTitle().ToLower().Contains("Dice"))
                {
                    DiceFounded.Add(result);
                }
            }

            foreach (var result in DiceFounded)
            {
                _softAssert.IsTrue(result.GetTitle().ToLower().Contains("Dice") &&
                    result.GetTitle().ToLower().Contains("dnd"),
                    "Every result should contain Dice and DnD in it's header: '" +
                    result.GetTitle() + "'");
            }

            _softAssert.AssertAll();

        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(5000);
        }
    }
}
