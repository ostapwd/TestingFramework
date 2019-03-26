using System;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace TestingFramework.Tools
{
    // Keeps isolated instance of WebDriver for every worker of NUnit
    // (for running web tests in parallel, replace ThreadLocal<>)
    public class WebDrivers
    {
        private Dictionary<string, IWebDriver> _driversPerWorkers = new Dictionary<string, IWebDriver>();

        public IWebDriver Value
        {
            get
            {
                return _driversPerWorkers.ContainsKey(GetCurrentWorkerId())
                    ? _driversPerWorkers[GetCurrentWorkerId()]
                    : null;
            }
            set { _driversPerWorkers[GetCurrentWorkerId()] = value; }
        }

        // For debugging purpouses
        private string GetCurrentWorkerId()
        {
            try
            {
                return TestContext.CurrentContext.WorkerId;
            }
            catch (NullReferenceException)
            {
                return "0";
            }
        }
    }
}
