using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace TestingFramework.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ug")]
        private readonly IWebElement _usernameButtonWebElement;

        [FindsBy(How = How.XPath, Using = "//input[@id='gh-ac']")]
        private readonly IWebElement _searchStringElement;

        private IWebElement AccountSettingsLinkWebElement
        {
            get
            {
                return Browser.GetDriver()
                    .FindElement(By.CssSelector("#gh-uac > a"));
            }
        }

        public void HoverMosueOverUserName()
        {
            Actions action = new Actions(Browser.GetDriver());
            action.MoveToElement(_usernameButtonWebElement)
                .Build().Perform();
        }

        public AccountSettingPage OpenAccountSettingsPage()
        {
            HoverMosueOverUserName();

            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(5))
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
