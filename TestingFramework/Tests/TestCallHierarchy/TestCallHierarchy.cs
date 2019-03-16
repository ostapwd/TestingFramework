using NUnit.Framework;

namespace TestingFramework.Tests.TestCallHierarchy
{
    [TestFixture(Author = "Ostap", Description = "This test do...")]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class TestCallHierarchy : BaseTestCallHierarchy
    {
        [OneTimeSetUp]
        public void TestOneTimeSetUp()
        {
            // one time before class
            Logs += "\tTestOneTimeSetUp\n";
        }

        [SetUp]
        public void TestSetUp()
        {
            // before each test
            Logs += "\t\t\tTestSetUp\n";
        }

        [Test]
        public void Test1()
        {
            Logs += "\t\t\t\tTest1\n";
        }

        [Test]
        public void Test2()
        {
            Logs += "\t\t\t\tTest2\n";
        }

        [Test]
        public void Test3()
        {
            Logs += "\t\t\t\tTest3\n";
        }

        [TearDown]
        public void TestTearDown()
        {
            // after each test
            Logs += "\t\t\tTestTearDown\n";
        }

        [OneTimeTearDown]
        public void TestOneTimeTearDown()
        {
            // one time after class
            Logs += "\tTestOneTimeTearDown\n";
        }
    }
}
