using NUnit.Framework;
using TestingFramework.Pages;
using TestingFramework.TestData;
using TestingFramework.Tools;

namespace TestingFramework.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CheckBoxesTest : BaseTest
    {
        private MessagesPage messagesPage;
        private SoftAssert _softAssert = null;

        [OneTimeSetUp]
        public void OpenMessagesPage()
        {
            messagesPage = StartPage.OpenLoginPage()
                .Login(UserData.User)
                .OpenMyEbayPage().OpenMessagesPage();
        }

        [SetUp]
        public void InitSoftAssert()
        {
            _softAssert = new SoftAssert();
        }

        [Test]
        public void VerifySelectCheckBoxesInTable()
        {
            //Wait.Time(TimeSpan.FromSeconds(5));

            messagesPage.CheckAll.Check();

            //List<CheckBox> cbList = messagesPage.GetAllTableCheckBoxes();
            
            foreach (var result in messagesPage.GetAllTableCheckBoxes())
            {
                _softAssert.IsTrue(result.IsSelected(), "Checkbox is not selected. Should be selected.");
            }

            _softAssert.AssertAll();

        }
        [Test]
        public void VerifyUnSelectCheckBoxesInTable()
        {
           // Wait.Time(TimeSpan.FromSeconds(5));

            messagesPage.CheckAll.UnCheck();

            foreach (var result in messagesPage.GetAllTableCheckBoxes())
            {
                _softAssert.IsFalse(result.IsSelected(), "Checkbox is selected. Should be unselected.");
            }
            
            _softAssert.AssertAll();

        }
    }
}

