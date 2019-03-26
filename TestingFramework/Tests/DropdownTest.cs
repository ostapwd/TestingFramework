using System;
using System.Threading;
using NUnit.Framework;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    [TestFixture(Author = "Ostap", Description = "This test checks category dropdown")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class DropdownTest : BaseTest
    {
        [Test]
        public void OpenDropdownTest()
        {
            StartPage.CategoriesDropdown.SelectByIndex(3);
            Wait.Time(1000);
            Console.WriteLine(StartPage.CategoriesDropdown.SelectedOption.Text);

            SelectCategoryDropdown dropdown = StartPage.CategoriesDropdown;
            dropdown.SelectByValue("550");
            Wait.Time(1000);
            dropdown.SelectByText("Crafts");
            Wait.Time(1000);

            dropdown.SelectDefaultValue();
        }

        [OneTimeTearDown]
        public void WaitBeforeClosing()
        {
            Wait.Time(1000);
        }
    }
}
