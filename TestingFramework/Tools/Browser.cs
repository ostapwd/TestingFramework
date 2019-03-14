using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingFramework.Tools
{
    class Browser
    {
        private Browser() { }
        private static readonly ThreadLocal<IWebDriver> Driver = new ThreadLocal<IWebDriver>();
        /// <summary>
        /// This method creates a new instance of a WebDriver,
        /// or returns already created.
        /// </summary>
        /// <returns>An instance of a WebDriver</returns>
        public static IWebDriver GetDriver()
        {
            if (Driver.Value == null)
            {
                Driver.Value = new ChromeDriver();
                Driver.Value.Manage().Window.Maximize();
            }

            return Driver.Value;
        }

        public static bool IsDriverStarted()
        {
            return Driver.Value != null;
        }

        public static void OpenStartPage()
        {
            GetDriver().Navigate().GoToUrl("https://www.ebay.com/");
        }

        public static void Close()
        {
            if (IsDriverStarted())
            {       
                //Driver.Value.Close();
                Driver.Value.Quit();
                Driver.Value = null;
            }
        }
    }

}
