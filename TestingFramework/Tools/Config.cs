using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace TestingFramework.Tools
{
    public static class Config
    {
        public static readonly TimeSpan WaitForWebElementDisplayed = TimeSpan.FromSeconds(10);

        public static readonly TimeSpan WaitForReadyState = TimeSpan.FromSeconds(5);

        public static readonly TimeSpan WaitForAjax = TimeSpan.FromSeconds(5);

        public static readonly bool TakeScreenshotsOnSuccess = Convert.ToBoolean(ConfigurationManager.AppSettings["TakeScreenshotsOnSuccess"]);

        public static readonly bool TakeScreenshotsOnFailure = Convert.ToBoolean(ConfigurationManager.AppSettings["TakeScreenshotsOnFailure"]);

        public static readonly string WebDriver = ConfigurationManager.AppSettings["WebDriver"];

        public static readonly string AppURI = ConfigurationManager.AppSettings["AppURI"];

        public static readonly string ScreenshotsDir = ConfigurationManager.AppSettings["ScreenshotsDir"];

        /// <summary>
        /// Gets path to project base root from environment where tests are run.
        /// </summary>
        /// <returns>Path to project base root.</returns>
        public static string GetRootDir()
        {
            var uri = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase);

            var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path))
                .Replace("\\TestingFramework\\bin\\Debug", "")
                .Replace("/TestingFramework/bin/Debug", "");

            return path;
        }

        public static void WriteLogs(string logs)
        {
            string path = Config.GetRootDir() + "\\logs.txt";
            Config.WriteTextToFile(path, logs);
        }

        public static void WriteTextToFile(string pathToFile, string dataToWrite)
        {
            File.WriteAllText(pathToFile, dataToWrite);
        }
    }
}
