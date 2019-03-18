using Ghpr.NUnit.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    public class BaseTest
    {
        protected StartPage StartPage;

        [OneTimeSetUp]
        public void BaseTestOneTimeSetUp()
        {
            Driver.OpenStartPage();
            StartPage = new StartPage();
        }

        [TearDown]
        public void TakeScreenshot()
        {
            var currentTestResult = TestContext.CurrentContext.Result.Outcome;

            if (Config.TakeScreenshotsOnFailure)
            {
                if (currentTestResult.Equals(ResultState.Failure) ||
                    currentTestResult.Equals(ResultState.Error) ||
                    currentTestResult.Equals(ResultState.Skipped) ||
                    currentTestResult.Equals(ResultState.SetUpFailure) ||
                    currentTestResult.Equals(ResultState.SetUpError))
                {
                    ScreenHelper.SaveScreenshot(Screenshot.TakeScreenshotFromDriver());
                }
            }

            if (Config.TakeScreenshotsOnSuccess)
            {
                if (currentTestResult.Equals(ResultState.Success))
                {
                    ScreenHelper.SaveScreenshot(Screenshot.TakeScreenshotFromDriver());
                }
            }
        }

        [OneTimeTearDown]
        public void BaseTestOneTimeTearDown()
        {
            Driver.Quit();
        }
    }
}
