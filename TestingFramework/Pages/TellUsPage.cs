using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public class TellUsPage : AbstractBasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#submitFdbk")]
        private readonly IWebElement _sendButtonWebElement;

        public Button SendButton
        {
            get { return new Button(_sendButtonWebElement); }
            private set { }
        }

        public bool IsSendButtonShown()
        {
            return SendButton.Displayed;
        }
    }
}

