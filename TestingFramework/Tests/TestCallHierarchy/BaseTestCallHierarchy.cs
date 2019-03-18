using NUnit.Framework;
using TestingFramework.Tools;

namespace TestingFramework.Tests.TestCallHierarchy
{
    public class BaseTestCallHierarchy
    {
        protected string Logs = "";

        [OneTimeSetUp]
        public void BaseTestOneTimeSetUp()
        {
            // one time before class
            Logs += "BaseTestOneTimeSetUp\n";
        }

        [SetUp]
        public void BaseTestSetUp()
        {
            // before each test
            Logs += "\t\tBaseTestSetUp\n";
        }

        [TearDown]
        public void BaseTestTearDown()
        {
            // after each test
            Logs += "\t\tBaseTestTearDown\n";
        }

        [OneTimeTearDown]
        public void BaseTestOneTimeTearDown()
        {
            // one time after class
            Logs += "BaseTestOneTimeTearDown\n";

            Config.WriteLogs(Logs);
        }
    }
}
