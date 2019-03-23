using OpenQA.Selenium;
using TestingFramework.CustomWebElements.ComplexWebElements;

namespace TestingFramework.CustomWebElements
{
    public class Input : AbstractWebElement
    {
        public Input(IWebElement webElement) : base(webElement)
        {
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
