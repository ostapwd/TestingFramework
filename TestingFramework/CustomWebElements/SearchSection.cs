using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class SearchSection
    {
        private IWebElement _wrappedWebElement;

        public SearchSection(IWebElement webElement)
        {
            _wrappedWebElement = webElement;
        }

        private IWebElement SearchStringElement
        {
            get
            {
                return _wrappedWebElement.FindElement(By.XPath("//input[@id='gh-ac']"));
            }
        }

        private IWebElement SearchButtonElement
        {
            get
            {
                return _wrappedWebElement.FindElement(By.XPath("//input[@id='gh-btn']"));

            }
        }

        public void Search(string text)
        {
            SearchStringElement.Clear();
            SearchStringElement.SendKeys(text);

            SearchButtonElement.Click();
        }
    }
}
