using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public class PersonalInformationPage : AbstractBasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'AboutMeLogin')]")]
        private readonly IWebElement aboutMePageEditLink;

        private IWebElement AboutMePageEditLink =>
            Driver.Get()
                .FindElement(By.XPath("//a[contains(@href, 'AboutMeLogin')]"));

        public string GetAboutMePageEditLinkText()
        {
            return AboutMePageEditLink.Text;
        }

        public void OpenAboutMePage()
        {
            aboutMePageEditLink.Click();
        }
    }
}
