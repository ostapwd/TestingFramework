using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingFramework
{
    static class Wait
    {
        public static void ForElementIsShown(IWebElement element)
        {
            ForElementIsShown(TimeSpan.FromSeconds(5), element);
        }

        public static void ForElementIsShown(TimeSpan timeSpan, IWebElement element)
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
