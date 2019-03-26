using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using TestingFramework.CustomWebElements;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    public class SearchForDnDTest : BaseTest
    {
        private SoftAssert _softAssert = null;

        [SetUp]
        public void SetUp()
        {
            _softAssert = new SoftAssert();
        }

        [Test, Order(1)]
        public void SearchForDiceTest()
        {
            StartPage.CategoriesDropdown.SelectByText("Toys & Hobbies");
            Wait.Time(1000);

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

        [Test, Order(1)]
        public void SearchDnDWithAndWithoutCategories()
        {
            StartPage.Search("DnD");
            Console.WriteLine(StartPage._searchRresults.Count);
            int AllCategoriesSearch = StartPage._searchRresults.Count;

            List<SearchResult> DiceFounded = new List<SearchResult>();
            foreach (var result in StartPage.GetAllSearchResults())
            {
                if (result.GetTitle().ToLower().Contains("Dice"))
                {
                    DiceFounded.Add(result);
                }
            }
            int AllCategoriesDices = DiceFounded.Count();
            Console.WriteLine(AllCategoriesDices);

            StartPage.CategoriesDropdown.SelectByText("Toys & Hobbies");
            Wait.Time(1000);

            StartPage.Search("DnD");
            Console.WriteLine(StartPage._searchRresults.Count);
            int CategorizedSearch = StartPage._searchRresults.Count;

            List<SearchResult> CategorizedDiceFounded = new List<SearchResult>();
            foreach (var result in StartPage.GetAllSearchResults())
            {
                if (result.GetTitle().ToLower().Contains("Dice"))
                {
                    CategorizedDiceFounded.Add(result);
                }
            }
            int CategorzedDices = CategorizedDiceFounded.Count();
            Console.WriteLine(CategorzedDices);

            Assert.AreEqual(CategorzedDices, AllCategoriesDices);
        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(1000);
        }
    }
}
