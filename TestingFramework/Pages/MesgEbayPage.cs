using System;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public class MesgEbayPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.CssSelector, Using = "#feedback-lnk")]
        private readonly IWebElement _FeedbackLinkWebElement;

        [FindsBy(How = How.CssSelector, Using = "#chkbox-master")]
        private readonly IWebElement _MasterCheckboxWebElement;

        [FindsBy(How = How.XPath, Using = "//tr[@class='msg-unread row']//input[@name='LineID']")]
        private readonly IWebElement _AllCheckMessagesWebElement;
        

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

        public Checkbox SelectAllChecked
        {
            get
            {
                return new Checkbox(_MasterCheckboxWebElement);
            }
            private set { }

        }

        //public List<Checkbox> RetrieveAllCheckboxes()
        //{
        //    //List<Checkbox> resultList = new List<Checkbox>(_AllCheckMessagesWebElement);
        //        //_AllCheckMessagesWebElement.Select(
        //        //element => new Checkbox(element)).ToList();

        //    return resultList;
        //}
    }
}
