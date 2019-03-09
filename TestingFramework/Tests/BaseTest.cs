using System.IO;
using Ghpr.NUnit.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    public class BaseTest
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

        [TearDown]
        public void TakeScreenIfFailed()
        {
            var res = TestContext.CurrentContext.Result.Outcome;
            if (res.Equals(ResultState.Failure) || res.Equals(ResultState.Error))
            {
                ScreenHelper.SaveScreenshot(Screenshot.TakeScreenshotFromBrowser());
            }
        }

        [OneTimeTearDown]
        public void BaseTestCloseTestFuxture()
        {
            logs += "BaseTestOneTimeTearDown\n";

            //Config.WriteLogs(logs);
        }
    }
}
