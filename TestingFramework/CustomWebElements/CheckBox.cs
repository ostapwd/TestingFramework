using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class CheckBox : AbstractWebElement
    {
        public CheckBox(IWebElement webElement) : base(webElement)
        {
        }

        public void Check()
        {
            if (!_wrappedWebElement.Selected)
                _wrappedWebElement.Click();
        }

        public void UnCheck()
        {
            if (_wrappedWebElement.Selected)
                _wrappedWebElement.Click();
        }

        public bool IsSelected()
        {
            return _wrappedWebElement.Selected;
        }
    }
}
