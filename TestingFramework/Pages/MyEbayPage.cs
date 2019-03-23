using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TestingFramework.Pages
{
    public class MyEbayPage : AbstractBasePageWithSection
    {

        //[FindsBy(How = How.XPath, Using = "\"//li[contains(@class,'tab')]//a[contains(text(), 'Messages')]")]

        //private readonly IWebElement _messagesLink;

        //public MessagesPage OpenMessagesPage()
        //{
        //    Wait.ForElementIsShown(_messagesLink, TimeSpan.FromSeconds(10));
        //    _messagesLink.Click();

        //    return new MessagesPage();
        //}

    }
}
