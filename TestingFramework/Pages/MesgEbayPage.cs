using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public class MesgEbayPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.CssSelector, Using = "#feedback-lnk")]
        private readonly IWebElement _FeedbackLinkWebElement;

        public Link FeedbackLinkWebElement
        {
            get
            {
                return new Link(_FeedbackLinkWebElement);
            }
            private set { }
        }

        public FeedbackFormPage ReachFeedbackForm()
        {
            FeedbackLinkWebElement.Click();
            Driver.SwitchToNewTab();
            return new FeedbackFormPage();
        }
    }
}
