using System;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingFramework.Tools
{
    static class Wait
    {
        public static void ForElementIsShown(IWebElement element)
        {
            ForElementIsShown(element, Config.WaitForWebElementDisplayed);
        }

        public static void ForElementIsShown(IWebElement element, TimeSpan timeSpan)
        {
            new WebDriverWait(Driver.Get(), timeSpan)
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

        public static IWebElement ForWebElement(IWebElement element, TimeSpan? timeSpan = null)
        {
            Wait.Time(100);
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(element)
            {
                Timeout = timeSpan ?? Config.WaitForWebElementDisplayed,
                PollingInterval = TimeSpan.FromMilliseconds(500)
            };
            Func<IWebElement, bool> condition = (IWebElement elementToCheck) =>
            {
                try
                {
                    return elementToCheck.Displayed;
                }
                catch (NoSuchElementException exception)
                {
                    return false;
                }
                catch (TargetInvocationException exception)
                {
                    if (exception.InnerException is NoSuchElementException)
                        return false;
                    throw;
                }
                catch (StaleElementReferenceException exception)
                {
                    return false;
                }
            };
            wait.Until(condition);

            return element;
        }

        public static void Time(TimeSpan timeToWait)
        {
            Thread.Sleep(timeToWait);
        }

        public static void Time(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
