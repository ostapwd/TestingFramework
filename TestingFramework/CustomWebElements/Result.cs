using OpenQA.Selenium;

namespace TestingFramework.CustomWebElements
{
    public class Result
    {
        private readonly IWebElement _wrappedWebElement;

        public Result(IWebElement webElement)
        {
            _wrappedWebElement = webElement;
        }

        public string GetTitle()
        {
            return _wrappedWebElement.FindElement(By.XPath(".//a[@class='s-item__link']/h3"))
                .Text;
        }

        public string GetPrice()
        {
            return _wrappedWebElement.FindElement(By.XPath(".//span[@class='s-item__price']"))
                .Text;
        }
    }
}
