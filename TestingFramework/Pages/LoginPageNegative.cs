using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public class LoginPageNegative : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//p[@id='errf']")]
        private readonly IWebElement _errorWebElement;

        public bool IsErrorLabelShown()
        {
            Wait.ForElementIsShown(_errorWebElement);
            return _errorWebElement.Displayed;
        }

        public string GetErrorLabelText()
        {
            return _errorWebElement.Text;
        }
    }
}
