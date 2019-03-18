using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestingFramework.CustomWebElements
{
    public class SelectCategoryDropdown : SelectElement
    {
        public SelectCategoryDropdown(IWebElement element) : base(element)
        {
        }

        public new void DeselectAll()
        {
            throw new NotImplementedException("This functionality is not supported!");
        }

        public virtual void SelectDefaultValue()
        {
            SelectByValue("0");
        }
    }
}
