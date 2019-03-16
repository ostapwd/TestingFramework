using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;
using TestingFramework.CustomWebElements;
using TestingFramework.Pages;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture()]
    class WrapperTest
    {
        //[Test]
        public void Test123()
        {
            Browser.OpenStartPage();

            StartPage startPage = new StartPage();

            startPage.CategoriesDropdown.SelectByIndex(3);
            Thread.Sleep(2000);
            Console.WriteLine(startPage.CategoriesDropdown.SelectedOption.Text);

            SelectCategoryDropdown dropdown = startPage.CategoriesDropdown;
            dropdown.SelectByValue("550");
            Thread.Sleep(2000);
            dropdown.SelectByText("Crafts");
            Thread.Sleep(2000);

            dropdown.SelectDefaultValue();
            // dropdown.
            //startPage.OpenLoginPage();

            //startPage.SignInButton.Click();
        }

        [OneTimeTearDown]
        public void CloseBr()
        {
            Thread.Sleep(5000);
            Browser.Close();
        }

    }
}
