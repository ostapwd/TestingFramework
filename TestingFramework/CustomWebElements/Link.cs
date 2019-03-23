using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFramework.CustomWebElements
{
    public class Link : AbstractWebElement
    {
        public Link(IWebElement webElement) : base(webElement)
        {
        }

        public void Click()
        {
            _wrappedWebElement.Click();
        }

        public string GetLinkText()
        {
            return _wrappedWebElement.Text;
        }
    }
}
