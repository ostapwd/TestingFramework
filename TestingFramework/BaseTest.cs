using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;

namespace TestingFramework
{
    class BaseTest
    {
        public string logs = "";


        [OneTimeSetUp]
        public void BaseTestPrepareTestFixture()
        { 
            logs += "BaseTestOneTimeSetUp\n";
            // StartBrowser();

            //  StartPage startPage = new StartPage();
            //  startPage.OpenLoginPage();
            //  LoginPage loginPOage = new LoginPage();

        }

        [OneTimeTearDown]
        public void BaseTestCloseTestFuxture()
        {
            logs += "BaseTestOneTimeTearDown\n";

            WriteToFile(logs);
            //  StartPage startPage = new StartPage();
            //  startPage.OpenLoginPage();
            //  LoginPage loginPOage = new LoginPage();



        }

        public void WriteToFile(string textToWrite)
        {
            string path = GetRootDir() + "\\logs.txt";
            File.WriteAllText(path, textToWrite);
        }

        /// <summary>
        /// Gets path to project base root from environment where tests are run.
        /// </summary>
        /// <returns>Path to project base root.</returns>
        private static string GetRootDir()
        {
            var uri = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase);

            var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path))
                .Replace("\\TestingFramework\\bin\\Debug", "");

            return path;
        }
    }
}
