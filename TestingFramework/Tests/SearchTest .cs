using System;
using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SearchTest : BaseTest
    {
        private SoftAssert _softAssert = null;
            
        [SetUp]
        public void SetUp()
        {
            _softAssert = new SoftAssert();
        }

        [Test]
        public void SearchForTeslaTest()
        {
            Console.WriteLine(StartPage._searchRresults.Count);

            StartPage.Search("Tesla");

            Console.WriteLine(StartPage._searchRresults.Count);

            Console.WriteLine(StartPage.GetSearchResult(0).GetTitle());
            Console.WriteLine(StartPage.GetSearchResult(0).GetPrice());

            // Method allows to scroll to WebElement
            JavaScriptExecutor.ScrollIntoView(StartPage.GetSearchResult(20).WrappedWebElement);
            Wait.Time(TimeSpan.FromSeconds(3));

            StartPage.GetSearchResult(40).ScrollIntoView();
            Wait.Time(TimeSpan.FromSeconds(3));

            StartPage.GetSearchResult(2).ScrollIntoView();
            Wait.Time(TimeSpan.FromSeconds(3));

            foreach (var result in StartPage.GetAllSearchResults())
            {
                _softAssert.IsTrue(result.GetTitle().ToLower().Contains("tesla"),
                    "Every result should contain 'tesla' in it's header: '" + result.GetTitle() + "'");
            }

            _softAssert.AssertAll();
        }
    }
}
