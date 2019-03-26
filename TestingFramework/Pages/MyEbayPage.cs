using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public class MyEbayPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'tab')]//a[contains(text(), 'Messages')]")]
        private readonly IWebElement _messagesLink;

        public MessagesPage OpenMessagesPage()
        {
            Wait.ForElementIsShown(_messagesLink, TimeSpan.FromSeconds(10));
            _messagesLink.Click();

            return new MessagesPage();
        }
		
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

        public MesgEbayPage OpenMessPage()
        {
            MessagesPageLinkWebElement.Click();
            return new MesgEbayPage();
        }
    }
}
