using System;
using System.Drawing;
using System.IO;
using OpenQA.Selenium;

namespace TestingFramework.Tools
{
    public static class Screenshot
    {
        public static void Take(string screenshotName)
        {
            string path = Config.GetRootDir() + "/Screenshots";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = path + "/" + screenshotName;

            byte[] screen = TakeScreenshotFromBrowser();
            File.WriteAllBytes(path, screen);
        }

        /// <summary>
        /// Takes screenshot from browser.
        /// </summary>
        /// <returns></returns>
        private static byte[] TakeScreenshotFromBrowser()
        {
            byte[] screen = null;
            if (Browser.IsDriverStarted())
                screen = ((ITakesScreenshot) Browser.GetDriver()).GetScreenshot().AsByteArray;

            return screen;
        }
    }
}