using System;
using NUnit.Framework;

namespace TestingFramework.Tests
{
    [TestFixture]
    public class Class1
    {
       

        [Test, Order(1)]
        public void Test1()
        {
            Console.WriteLine("Running Test1");
        }

        [Test, Order(5)]
        public void Test2()
        {
            Console.WriteLine("Running Test2");
            Assert.True(7 < 8, "7 should be more than 8");
            // Assert.IsTrue(false);
        }

        [Test, Order(2), TestCaseSource("TestData")]
        public void TestAddFunction(int a, int b, int result)
        {
            //int res = Add(a, b);
            Assert.AreEqual(result, Add(a, b), "Wrong result");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        private static readonly object[] TestData =
        {
            new object[] {10, 20, 30},
            new object[] {1, 5, 6},
            new object[] {50, 60, 100},
            new object[] {6, 9, 15}
        };


        [Test, Order(22), TestCaseSource("TestData2")]
        public void TestSomth(int a, int b, string someText)
        {
            Console.WriteLine(a + " " + b + " " + someText);
        }

        private static readonly object[] TestData2 =
        {
            new object[] {10, 20, "rrr"},
            new object[] {1, 5, "qqqq"}
            //new object[] {50, 60, 100},
            //new object[] {6, 9, 15}
        };

        [TestCase(4, 3, "Hi")]
        [TestCase(9, 10, "Hi1")]
        public void TestDD(int a, int b, string someText)
        {
            Console.WriteLine(a + " " + b + " " + someText);
        }

        [Test, Order(57)]
        public void Test57()
        {
            Console.WriteLine("Running Test57 stage 1");

            Assert.True(7 < 8, "7 should be more than 8");
            Console.WriteLine("Running Test57 stage 2");
            //throw  new Exception("Hi I am exc");
            Assert.True(9 < 8, "9 should be more than 9");
            Console.WriteLine("Running Test57 stage 3");

        }
    }
}
