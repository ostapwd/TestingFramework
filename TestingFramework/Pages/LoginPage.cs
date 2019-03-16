using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TestingFramework.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#userid")]
        private readonly IWebElement _usernanmeInputWebElement;

        [FindsBy(How = How.CssSelector, Using = "#pass")]
        private readonly IWebElement _passwordInputWebElement;

        [FindsBy(How = How.CssSelector, Using = "#sgnBt")]
        private readonly IWebElement _signInButtonWebElement;

        public Button SignInButton => new Button(_signInButtonWebElement);
        public Input LoginInput => new Input(_usernanmeInputWebElement);
        public Input PassInput => new Input(_passwordInputWebElement);

        public Input UsernameInput
        {
            get { return new Input(_usernanmeInputWebElement);}
        }

        public HomePage Login()
        {
            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#userid")));

            LoginInput.SetValue("ostapwdwdwd@gmail.com");
            PassInput.SetValue("fR7Hsj2k!kkd3");
            SignInButton.Click();

            //_usernanmeInputWebElement.Clear();
            //_usernanmeInputWebElement.SendKeys("ostapwdwdwd@gmail.com");

            //_usernanmeInputWebElement.Click();
            //_passwordInputWebElement.SendKeys("fR7Hsj2k!kkd3");

            //_signInButtonWebElement.Click();

            return new HomePage();
        }

        public HomePage Login(string login, string password)
        {
            _usernanmeInputWebElement.SendKeys(login);
            _passwordInputWebElement.SendKeys(password);

            _signInButtonWebElement.Click();

            return new HomePage();
        }

        public LoginPageNegative LoginNegative(string login, string password)
        {
            _usernanmeInputWebElement.SendKeys(login);
            _passwordInputWebElement.SendKeys(password);

            _signInButtonWebElement.Click();

            return new LoginPageNegative();
        }

    }
}
