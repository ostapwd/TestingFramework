using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestingFramework.CustomWebElements;
using TestingFramework.Tools;
using System.Collections.Generic;
using System.Linq;

namespace TestingFramework.Pages
{
    public class MessagesPage : AbstractBasePageWithSection
    {
        [FindsBy(How = How.XPath, Using = "//a[@id='feedback-lnk']")]
        private readonly IWebElement _tellusLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='chkbox-master']")]
        private readonly IWebElement _checkAllWebElement;

        [FindsBy(How = How.XPath, Using = "//tr[@class='msg-unread row']//input[@name='LineID']")]
        private readonly IList<IWebElement> _tableCheckBoxesWebElement;

        public CheckBox CheckAll
        {
            get { return new CheckBox(_checkAllWebElement); }
            private set { }
        }

        public List<CheckBox> GetAllTableCheckBoxes()
        {
            List<CheckBox> searchResults =
                _tableCheckBoxesWebElement.Select(webElement => new CheckBox(webElement)).ToList();
            return searchResults;
        }

        public TellUsPage OpenTellUsPage()
        {
            Wait.ForElementIsShown(_tellusLink, TimeSpan.FromSeconds(10));
            _tellusLink.Click();

            Driver.SwitchToNewTab();

            return new TellUsPage();
        }
    }
}
