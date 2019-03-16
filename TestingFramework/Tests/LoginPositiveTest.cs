using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    class LoginPositiveTest : BaseTest
    {
        private LoginPage _loginPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            logs += "\tOneTimeSetUp\n";
            Browser.OpenStartPage();

            StartPage startPage = new StartPage();
            startPage.OpenLoginPage();

            _loginPage = new LoginPage();
            //Screenshot.Take("Screen1.jpg");
        }

        [SetUp]
        public void PrepareEachTest()
        {
            // do somth before every test
            logs += "\t\t\tPrepareEachTest\n";
        }

        [TearDown]
        public void ClearAfterEachTest()
        {
            // do somth after every test
            logs += "\t\t\tClearAfterEachTest\n";
        }


        [Test]
        public void PositiveLoginTest()
        {
            logs += "\t\t\t\tTest\n";
            bool isElementShown = _loginPage.Login("ostapwdwdwd@gmail.com", "fR7Hsj2k!kkd3").IsSearchStringShown();

            Assert.IsTrue(isElementShown, "Error message should be shown!");
            //Console.Read();
            //LoginPageNegative loginPageNegative = new LoginPageNegative();

            //bool isElementShown = loginPageNegative.IsErrorLabelShown();
            //string elementInnerText = loginPageNegative.GetErrorLabelText();

            //Screenshot.Take("Screen2.jpg");

            //Assert.IsTrue(isElementShown, "Error message should be shown!");
            //Assert.AreEqual("Oops, that's not a match!", elementInnerText);


            //Console.WriteLine(isElementShown);
            //Console.WriteLine(elementInnerText);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            logs += "\tOneTimeTearDown\n";
            Browser.Close();
        }
    }
}
