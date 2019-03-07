using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingFramework.Pages
{
    public class PersonalInformationPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'AboutMeLogin')]")]
        private readonly IWebElement aboutMePageEditLink;

        private IWebElement AboutMePageEditLink
        {
            get
            {
                return Browser.GetDriver()
                    .FindElement(By.XPath("//a[contains(@href, 'AboutMeLogin')]"));
            }
        }

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
