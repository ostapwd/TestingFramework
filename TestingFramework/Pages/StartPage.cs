using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Pages
{
    public class StartPage : BasePageWithSection
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ug > a")]
        private readonly IWebElement _signInButtonWebElement;

        public Button SignInButton => new Button(_signInButtonWebElement);

        public LoginPage OpenLoginPage()
        {
            SignInButton.Click();
            return new LoginPage();
        }
    }
}
