using OpenQA.Selenium;

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
