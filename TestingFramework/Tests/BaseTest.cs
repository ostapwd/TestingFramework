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
            Browser.OpenStartPage();
            StartPage = new StartPage();
        }

        [TearDown]
        public void TakeScreenIfFailed()
        {
            var currentTestResult = TestContext.CurrentContext.Result.Outcome;
            if (currentTestResult.Equals(ResultState.Failure) ||
                currentTestResult.Equals(ResultState.Error))
            {
                ScreenHelper.SaveScreenshot(Screenshot.TakeScreenshotFromBrowser());
            }
        }

        [OneTimeTearDown]
        public void BaseTestOneTimeTearDown()
        {
            Browser.Close();
        }
    }
}
