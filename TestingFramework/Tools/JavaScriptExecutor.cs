using OpenQA.Selenium;

namespace TestingFramework.Tools
{
    public static class JavaScriptExecutor
    {
        public static void JsClick(IWebElement element)
        {
            (Driver.Get() as IJavaScriptExecutor)
                .ExecuteScript("arguments[0].click();", element);
        }

        public static void SetAttribute(IWebElement element, string attributeName, string attributeValue)
        {
            (Driver.Get() as IJavaScriptExecutor)
                .ExecuteScript("arguments[0].setAttribute('" + attributeName + "', '" + attributeValue + "')", element);
        }

        public static void ScrollIntoView(IWebElement element)
        {
            (Driver.Get() as IJavaScriptExecutor)
                .ExecuteScript("arguments[0].scrollIntoView(true)", element);
        }
    }
}