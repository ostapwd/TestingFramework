using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingFramework.Tools
{
    class Browser
    {
        private Browser() { }

        private static IWebDriver _driver = null;

        /// <summary>
        /// This method creates a new instance of a WebDriver,
        /// or returns already created.
        /// </summary>
        /// <returns>An instance of a WebDriver</returns>
        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
            }

            return _driver;
        }

        public static bool IsDriverStarted()
        {
            return _driver != null;
        }

        public static void OpenStartPage()
        {
            GetDriver().Navigate().GoToUrl("https://www.ebay.com/");
        }
    }

}
