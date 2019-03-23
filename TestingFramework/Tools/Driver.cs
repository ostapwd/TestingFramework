using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TestingFramework.Tools
{
    class Driver
    {
        private Driver()
        {
        }

        private static readonly WebDrivers WebDrivers = new WebDrivers();

        /// <summary>
        /// This method creates a new instance of a WebDriver,
        /// or returns already created.
        /// </summary>
        /// <returns>An instance of a WebDriver</returns>
        public static IWebDriver Get()
        {
            if (WebDrivers.Value == null)
                WebDrivers.Value = StartDriver();

            return WebDrivers.Value;
        }

        private static IWebDriver StartDriver()
        {
            IWebDriver driver = null;

            if (Config.WebDriver.Equals("Chrome"))
                driver = new ChromeDriver();
            else if (Config.WebDriver.Equals("Firefox"))
                driver = new FirefoxDriver();
            else if (Config.WebDriver.Equals("InternetExplorer"))
                driver = new InternetExplorerDriver();
            else
            {
                throw new Exception("Wrong webdriver! Please check settings is the App.config file!");
            }

            driver.Manage().Window.Maximize();
            return driver;
        }

        public static bool IsDriverStarted()
        {
            return WebDrivers.Value != null;
        }

        public static void OpenStartPage()
        {
            Get().Navigate().GoToUrl(Config.AppURI);
        }

        public static void SwitchToNewTab()
        {
            var windows = Get().WindowHandles;
            var currentWindow = Get().CurrentWindowHandle;
            var newWindow = windows.First(i => !i.Equals(Driver.Get().CurrentWindowHandle));
            Get().SwitchTo().Window(newWindow);
        }

        public static void Quit()
        {
            if (IsDriverStarted())
            {
                WebDrivers.Value.Quit();
                WebDrivers.Value = null;
            }
        }
    }
}
