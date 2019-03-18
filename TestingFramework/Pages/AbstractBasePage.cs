using SeleniumExtras.PageObjects;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public abstract class AbstractBasePage
    {
        protected AbstractBasePage()
        {
            PageFactory.InitElements(Driver.Get(), this);
        }
    }
}
