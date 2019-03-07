using SeleniumExtras.PageObjects;

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
