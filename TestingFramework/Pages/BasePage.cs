using SeleniumExtras.PageObjects;
using TestingFramework.Tools;

namespace TestingFramework.Pages
{
    public abstract class BasePage
    {
        protected BasePage()
        {
            PageFactory.InitElements(Browser.GetDriver(), this);
        }
    }
}
