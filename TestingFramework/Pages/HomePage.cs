using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace TestingFramework.Pages
{
    public class HomePage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ug")]
        private readonly IWebElement _usernameButtonWebElement;

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        private readonly IWebElement _searchStringElement;

        [FindsBy(How = How.XPath, Using = ".//a[text()=' My eBay']")]
        private readonly IWebElement _myEbayLink;

        public MyEbayPage OpenMyEbayPage()
        {
            Wait.ForElementIsShown(_myEbayLink, TimeSpan.FromSeconds(10));
            _myEbayLink.Click();

            return new MyEbayPage();
        }

        private IWebElement AccountSettingsLinkWebElement
        {
            get
            {
                return Driver.Get()
                    .FindElement(By.CssSelector("#gh-uac > a"));
            }
        }

        public void HoverMosueOverUserName()
        {
            Actions action = new Actions(Driver.Get());
            action.MoveToElement(_usernameButtonWebElement)
                .Build().Perform();
        }

        public AccountSettingPage OpenAccountSettingsPage()
        {
            HoverMosueOverUserName();

            new WebDriverWait(Driver.Get(), TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#gh-uac > a")));

            AccountSettingsLinkWebElement.Click();

            return new AccountSettingPage();
        }

        public bool IsSearchStringShown()
        {
            Wait.ForElementIsShown(_searchStringElement);
            return _searchStringElement.Displayed;
        }
    }
}
