using System.IO;
using NUnit.Framework;
using TestingFramework.Tools;

namespace TestingFramework.Tests
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

            Config.WriteLogs(logs);
        }
    }
}
