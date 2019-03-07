using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    class Input
    {
        private readonly IWebElement _wrappedWebElement;

        public Input(IWebElement webElement)
        {
            _wrappedWebElement = webElement;
        }

        public void SetValue(string valueToSet)
        {
            _wrappedWebElement.Clear();
            _wrappedWebElement.SendKeys(valueToSet);
        }

        public string GetText()
        {
            return _wrappedWebElement.Text;
        }
    }
}
