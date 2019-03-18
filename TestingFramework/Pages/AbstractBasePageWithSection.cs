using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public abstract class AbstractBasePageWithSection : AbstractBasePage
    {
        protected AbstractBasePageWithSection() : base()
        {
        }

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        private readonly IWebElement _searchStringElement;

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-btn']")]
        private readonly IWebElement _searchButtonElement;

        [FindsBy(How = How.CssSelector, Using = "#gh-cat")]
        private readonly IWebElement _categoriesDropdownElement;

        [FindsBy(How = How.CssSelector, Using = ".srp-results > .s-item")]
        public readonly IList<IWebElement> _searchRresults;

        public SelectCategoryDropdown CategoriesDropdown => new SelectCategoryDropdown(_categoriesDropdownElement);

        public void Search(string text)
        {
            _searchStringElement.Clear();
            _searchStringElement.SendKeys(text);

            _searchButtonElement.Click();

        }

        public SearchResult GetSearchResult(int index)
        {
            SearchResult result = new SearchResult(_searchRresults[index]);
            return result;
        }

        public List<SearchResult> GetAllSearchResults()
        {
            List<SearchResult> searchResults =
                _searchRresults.Select(webElement => new SearchResult(webElement)).ToList();
            return searchResults;
        }
    }
}
