using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    class Button
    {
        private readonly IWebElement _wrappedWebElement;

        public Button(IWebElement webElement)
        {
            _wrappedWebElement = webElement;
        }

        public void Click()
        {
            _wrappedWebElement.Click();
        }
    }
}
