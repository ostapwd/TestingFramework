using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingFramework.Pages
{
    public class StartPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ug > a")]
        private readonly IWebElement _signInButtonWebElement;

        public LoginPage OpenLoginPage()
        {
            _signInButtonWebElement.Click();

            return new LoginPage();
        }
    }
}
