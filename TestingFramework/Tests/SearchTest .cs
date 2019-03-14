using System;
using System.Threading;
using Ghpr.NUnit.Utils;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using TestingFramework.Pages;
using TestingFramework.Tools;
using Screenshot = TestingFramework.Tools.Screenshot;

namespace TestingFramework.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class SearchTest : BaseTest
    {
        private LoginPage _loginPage;
        private StartPage _startPage;

        [OneTimeSetUp]
        public void OpenLoginPage()
        {
            Browser.OpenStartPage();

            _startPage = new StartPage();
            //startPage.OpenLoginPage();

            //_loginPage = new LoginPage();

            Screenshot.Take("Screen1.jpg");
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
        public void SearchForTeslaTest()
        {
            
            Console.WriteLine(_startPage._searchRresults.Count);

            _startPage.Search("Tesla");

            Console.WriteLine(_startPage._searchRresults.Count);

            Console.WriteLine(_startPage.GetResult(0).GetTitle());
            Console.WriteLine(_startPage.GetResult(0).GetPrice());

            _startPage.GetResults().ForEach(item => 
                Console.WriteLine(item.GetTitle() + " \t" + item.GetPrice()));

            //foreach (var result in _startPage._searchRresults)
            //{
            //    string textOfTheFirstElement = result
            //        .FindElement(By.XPath(".//a[@class='s-item__link']/h3")).Text;

            //    Console.WriteLine(textOfTheFirstElement);
            //}

            //_startPage.SearchRresultsList().ForEach(item => 
            //    Console.WriteLine("\t" +
            //        item.FindElement(By.XPath(".//span[@class='s-item__price']")).Text
            //        ));


            //HomePage homePage = _loginPage.Login("ostapwdwdwd@gmail.com", "fR7Hsj2k!kkd3");
            //MyEbayPage myEbayPage = homePage.OpenMyEbayPage();

            //Console.WriteLine(myEbayPage._searchRresults.Count);
            //myEbayPage.Search("Tesla");

            //Console.WriteLine(myEbayPage._searchRresults.Count);
        }

        [Test]
        public void SearchForTeslaTest2()
        {
            HomePage homePage = _startPage.OpenLoginPage().Login("ostapwdwdwd@gmail.com", "fR7Hsj2k!kkd3");

            homePage.GetSearchSection().Search("tesla pppp");

          Thread.Sleep(10000);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            logs += "\tOneTimeTearDown\n";
            Browser.Close();
        }

    }
}
