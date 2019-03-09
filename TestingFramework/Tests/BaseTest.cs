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
        }

        [TearDown]
        public void TakeScreenIfFailed()
        {
            logs += "\t\tBaseTestTearDown\n";
            var currentTestResult = TestContext.CurrentContext.Result.Outcome;
            if (currentTestResult.Equals(ResultState.Failure) ||
                currentTestResult.Equals(ResultState.Error))
            {
                ScreenHelper.SaveScreenshot(Screenshot.TakeScreenshotFromBrowser());
            }
        }

        [SetUp]
        public void PrepareEachTest()
        {
            // do somth before every test
            logs += "\t\tBaseTestSetUp\n";
        }

        [OneTimeTearDown]
        public void BaseTestCloseTestFuxture()
        {
            logs += "BaseTestOneTimeTearDown\n";

            Config.WriteLogs(logs);
        }
    }
}
