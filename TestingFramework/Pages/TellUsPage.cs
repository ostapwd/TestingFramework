
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

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

        //[FindsBy(How = How.XPath, Using = "")]
        //private readonly IWebElement _tellusLink;

        //public MyEbayPage TellUsPage()
        //{
        //    Wait.ForElementIsShown(_tellusLink, TimeSpan.FromSeconds(10));
        //    _tellusLink.Click();

        //    return new MyEbayPage();
        //}


    }
}

