using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingFramework.Tools
{
    static class Wait
    {
        public static void ForElementIsShown(IWebElement element)
        {
            ForElementIsShown(element, TimeSpan.FromSeconds(5));
        }

        public static void ForElementIsShown(IWebElement element, TimeSpan timeSpan)
        {
            new WebDriverWait(Browser.GetDriver(), timeSpan)
                .Until((driver =>
                {
                    Console.WriteLine("check if element is shown");
                    try
                    {
                        return element.Displayed;
                    }
                    catch (NoSuchElementException e)
                    {
                        return false;
                    }
                }));
        }
    }
}
