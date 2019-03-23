using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class Button : AbstractWebElement
    {
        public Button(IWebElement webElement) : base(webElement)
        {
        }

        public void Click()
        {
            _wrappedWebElement.Click();
        }
    }
}
