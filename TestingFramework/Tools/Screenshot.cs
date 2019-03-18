using System.IO;
using OpenQA.Selenium;

namespace TestingFramework.Tools
{
    public static class Screenshot
    {
        public static void Take(string screenshotName)
        {
            string path = Config.GetRootDir() + "/" + Config.ScreenshotsDir;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = path + "/" + screenshotName;

            byte[] screen = TakeScreenshotFromDriver();
            File.WriteAllBytes(path, screen);
        }

        /// <summary>
        /// Takes screenshot from browser.
        /// </summary>
        /// <returns></returns>
        public static byte[] TakeScreenshotFromDriver()
        {
            byte[] screen = null;
            if (Driver.IsDriverStarted())
                screen = ((ITakesScreenshot) Driver.Get()).GetScreenshot().AsByteArray;

            return screen;
        }
    }
}