using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public abstract class BasePageWithSection : BasePage
    {
        protected BasePageWithSection():base()
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#gh-cat")]
        private readonly IWebElement _categoriesDropdownElement;

        public SelectCategoryDropdown CategoriesDropdown => new SelectCategoryDropdown(_categoriesDropdownElement);

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        private readonly IWebElement _searchStringElement;

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-btn']")]
        private readonly IWebElement _searchButtonElement;

        public void Search(string text)
        {
            _searchStringElement.Clear();
            _searchStringElement.SendKeys(text);

            _searchButtonElement.Click();

        }

        [FindsBy(How = How.CssSelector, Using = ".srp-results > .s-item")]
        public readonly IList<IWebElement> _searchRresults;

        public Result GetResult(int index)
        {
            Result r = new Result(_searchRresults[index]);

            return r;
        }

        public List<Result> GetResults()
        {
            List<Result> searchResults = new List<Result>();
            foreach (var resultAsWebElement in _searchRresults)
            {
                Result r = new Result(resultAsWebElement);
                searchResults.Add(r);
            }

            return searchResults;
        }

        public List<IWebElement> SearchRresultsList()
        {
            List<IWebElement> searchRresults = new List<IWebElement>();
            foreach (var res in _searchRresults)
            {
                searchRresults.Add(res);
            }

            return searchRresults;
        }
    }
}
