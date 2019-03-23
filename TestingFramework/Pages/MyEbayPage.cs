using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public class MyEbayPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'tab')]//a[contains(text(), 'Messages')]")]
        private readonly IWebElement _messagesPageLinkWebElement;

        public Link MessagesPageLinkWebElement
        {
            get
            {
                return new Link(_messagesPageLinkWebElement);
            }
            private set { }
        }

        public MesgEbayPage OpenMessagesPage()
        {
            MessagesPageLinkWebElement.Click();
            return new MesgEbayPage();
        }

    }
}
