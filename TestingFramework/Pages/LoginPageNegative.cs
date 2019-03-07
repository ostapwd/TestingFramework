using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingFramework.Pages
{
    public class LoginPageNegative : BasePage
    {
        //public LoginPageNegative()
        //{
        //    PageFactory.InitElements(Browser.GetDriver(), this);
        //}

        [FindsBy(How = How.XPath, Using = "//p[@id='errf']")]
        private readonly IWebElement _errorWebElement1;

        [FindsBy(How = How.XPath, Using = "//p[@id='errf']")]
        private readonly IWebElement _errorWebElement2;

        [FindsBy(How = How.XPath, Using = "//p[@id='fxghfgjhjgxhfvcghjkhxdf']")]
        private readonly IWebElement _errorWebElement3;

        [FindsBy(How = How.XPath, Using = "//p[@id='errf']")]
        private readonly IWebElement _errorWebElement4;


        private readonly IWebElement _errorWebElement = Browser.GetDriver()
            .FindElement(By.XPath("//p[@id='errf']"));

        public bool IsErrorLabelShown()
        {
            Wait.ForElementIsShown(_errorWebElement1);
            return _errorWebElement1.Displayed;
        }

        public string GetErrorLabelText()
        {
            return _errorWebElement1.Text;
        }

    }
}
