using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class CheckBox : AbstractWebElement
    {
        public CheckBox(IWebElement webElement) : base(webElement)
        {
        }

        public void Select()
        {
            if (!_wrappedWebElement.Selected)
                _wrappedWebElement.Click();
        }

        public void Unselect()
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
