using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public class MyEbayPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-f")]
        private readonly IWebElement _searchContainer;

        public SearchSection GetSearchSection()
        {
            return new SearchSection(_searchContainer);
        }

    }
}
