using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TestingFramework.Pages
{
    public class MessagesPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='feedback-lnk']")]
        private readonly IWebElement _tellusLink;

        public TellUsPage OpenTellUsPage()
        {
            Wait.ForElementIsShown(_tellusLink, TimeSpan.FromSeconds(10));
            _tellusLink.Click();

            return new TellUsPage();
        }


    }
}
