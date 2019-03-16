using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.TestData;
using TestingFramework.Tools;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace TestingFramework.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#userid")]
        private readonly IWebElement _loginInputWebElement;

        [FindsBy(How = How.CssSelector, Using = "#pass")]
        private readonly IWebElement _passwordInputWebElement;

        [FindsBy(How = How.CssSelector, Using = "#sgnBt")]
        private readonly IWebElement _signInButtonWebElement;

        public Button SignInButton => new Button(_signInButtonWebElement);
        public Input LoginInput => new Input(_loginInputWebElement);
        public Input PasswordInput => new Input(_passwordInputWebElement);

        public HomePage Login()
        {
            new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(5))
                .Until(ExpectedConditions.ElementIsVisible(By.CssSelector("#userid")));

            LoginInput.SetValue(UserData.Login);
            PasswordInput.SetValue(UserData.Password);
            SignInButton.Click();

            return new HomePage();
        }

        public HomePage Login(string login, string password)
        {
            LoginInput.SetValue(login);
            PasswordInput.SetValue(password);
            SignInButton.Click();

            return new HomePage();
        }

        public HomePage Login(UserModel user)
        {
            LoginInput.SetValue(user.Login);
            PasswordInput.SetValue(user.Password);
            SignInButton.Click();

            return new HomePage();
        }
        public LoginPageNegative LoginNegative(string login, string password)
        {
            LoginInput.SetValue(login);
            PasswordInput.SetValue(password);
            SignInButton.Click();

            return new LoginPageNegative();
        }

    }
}
