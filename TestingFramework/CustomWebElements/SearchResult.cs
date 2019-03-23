using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TestingFramework.CustomWebElements
{
    public class SearchResult : AbstractWebElement
    {
        public SearchResult(IWebElement webElement) : base(webElement)
        {
        }

        [FindsBy(How = How.XPath, Using = ".//a[@class='s-item__link']/h3")]
        private readonly IWebElement _titleWEbElement;

        [FindsBy(How = How.XPath, Using = ".//span[@class='s-item__price']")]
        private readonly IWebElement _priceWEbElement;

        public string GetTitle()
        {
            return _titleWEbElement.Text;
        }

        public string GetPrice()
        {
            return _priceWEbElement.Text;
        }
    }
}
