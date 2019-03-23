using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;

namespace TestingFramework.CustomWebElements
{
    public abstract class AbstractWebElement
    {
        protected AbstractWebElement(IWebElement webElement)
        {
            this._wrappedWebElement = webElement;
            PageFactory.InitElements(this, new DefaultElementLocator(this._wrappedWebElement));
        }

        protected IWebElement _wrappedWebElement;

        public IWebElement WrappedWebElement
        {
            get { return this._wrappedWebElement; }
            private set { }
        }

        public virtual bool Enabled
        {
            get { return this._wrappedWebElement.Enabled; }
        }

        public virtual bool Displayed
        {
            get { return this._wrappedWebElement.Displayed; }
        }

        public virtual AbstractWebElement ScrollIntoView()
        {
            JavaScriptExecutor.ScrollIntoView(this._wrappedWebElement);
            return this;
        }  
    }
}