//using System;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.PageObjects;
//using TestingFramework.Tools;
//using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
//namespace TestingFramework.Pages
//{
//    public class MessagesPage : AbstractBasePage
//    {

//        [FindsBy(How = How.XPath, Using = ".//a[text()='Tell us what you think']")]
//        private readonly IWebElement _tellUsWhatYouThinkLink;

//        public TellUsWhatYouThinkPage OpenTellUsWhatYouThink()
//        {


//            Wait.ForElementIsShown(_tellUsWhatYouThinkLink, TimeSpan.FromSeconds(10));
//            _tellUsWhatYouThinkLink.Click();

//            return new TellUsWhatYouThinkPage();


//        }
//    }
//}

