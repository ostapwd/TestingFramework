using System;
using System.IO;
using NUnit.Framework;

namespace TestingFramework
{
    [TestFixture(Author = "Ostap", Description = "This test do...")]
    [Parallelizable(ParallelScope.Fixtures)]
    class LoginPageTest : BaseTest
    {
        // private LoginPage loginPage;

        //public string logs = "";

        [OneTimeSetUp]
        public void PrepareTestFixture()
        {
            logs += "\tOneTimeSetUp\n";
            // StartBrowser();

            //  StartPage startPage = new StartPage();
            //  startPage.OpenLoginPage();
            //  LoginPage loginPOage = new LoginPage();

        }

        [SetUp]
        public void PrepareEachTest()
        {
            // do somth before every test
            logs += "\t\tPrepareEachTest\n";
        }

        [TearDown]
        public void ClearAfterEachTest()
        {
            // do somth after every test
            logs += "\t\tClearAfterEachTest\n";
        }


        public delegate int MyDelegate(int par, string s);

        public int DoS(int par, string s)
        {
            Console.WriteLine(s);
            return par + 10;
        }

        public int MMMM(int par, string s)
        {
            Console.WriteLine(s + " iiii ");
            return par + 10;
        }

        [Test, Order(1)]
        public void TestUsernameInput()
        {
            MyDelegate d = DoS;
            MyDelegate d1 = MMMM;

            int res = d.Invoke(7, "hello");
            Console.WriteLine(res);

            d(9, "dddd");

            d1(9, "dddd");

            logs += "\t\t\tTestUsernameInput\n";
            //Assert.IsTrue(loginPage.IsShown());
        }

        [Test, Order(2)]
        public void TestPasswordInput()
        {
            logs += "\t\t\tTestPasswordInput\n";
            //Assert.IsTrue(loginPage.IsShown());
        }

        [Test, Order(3)]
        public void TestLoginButton()
        {
            logs += "\t\t\tTestLoginButton\n";
            //Assert.IsTrue(loginPage.IsShown());
        }

        [OneTimeTearDown]
        public void CloseTestFuxture()
        {
            logs += "\tOneTimeTearDown\n";

           
            // Browser.Quit();
        }

       
    }
}
