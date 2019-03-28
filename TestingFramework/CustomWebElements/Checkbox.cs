using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class Checkbox : AbstractWebElement
    {
        public Checkbox(IWebElement webElement) : base(webElement)
        {
        }

        public void Click()
        {
            _wrappedWebElement.Click();
        }

        public void Check()
        {
            if (!_wrappedWebElement.Selected)
            {
                _wrappedWebElement.Click();
            }
        }

        public void UnCheck()
        {
            if (_wrappedWebElement.Selected)
            {
                _wrappedWebElement.Click();
            }
        }

        public bool IsChecked()
        {
            return _wrappedWebElement.Selected;
        }
    }
}
