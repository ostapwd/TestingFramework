using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public class StartPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ug > a")]
        private readonly IWebElement _signInButtonWebElement;

        public LoginPage OpenLoginPage()
        {
            _signInButtonWebElement.Click();

            return new LoginPage();
        }


        #region Search not in contrainer (old version)

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

        #endregion

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
            List<IWebElement>  searchRresults = new List<IWebElement>();
            foreach (var res in _searchRresults)
            {
                searchRresults.Add(res);
            }

            return searchRresults;
        }
        
    }
}
