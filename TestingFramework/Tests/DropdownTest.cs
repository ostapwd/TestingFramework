using System;
using System.Threading;
using NUnit.Framework;
using TestingFramework.CustomWebElements;

namespace TestingFramework.Tests
{
    [TestFixture]
    public class DropdownTest : BaseTest
    {
        [Test]
        public void OpenDropdownTest()
        {
            StartPage.CategoriesDropdown.SelectByIndex(3);
            Thread.Sleep(2000);
            Console.WriteLine(StartPage.CategoriesDropdown.SelectedOption.Text);

            SelectCategoryDropdown dropdown = StartPage.CategoriesDropdown;
            dropdown.SelectByValue("550");
            Thread.Sleep(2000);
            dropdown.SelectByText("Crafts");
            Thread.Sleep(2000);

            dropdown.SelectDefaultValue();
        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Thread.Sleep(5000);
        }

    }
}
