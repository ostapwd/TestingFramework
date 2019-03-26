using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingFramework.Pages
{
    public class AccountSettingPage : AbstractBasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Personal Information']")]
        private readonly IWebElement _personalInformationLinkWebElement;

        public PersonalInformationPage OpenPersonalInformationPage()
        {
            _personalInformationLinkWebElement.Click();

            return new PersonalInformationPage();
        }
    }
}
