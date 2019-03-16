using System;
using NUnit.Framework;

namespace TestingFramework.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class SearchTest : BaseTest
    {
        [Test]
        public void SearchForTeslaTest()
        {       
            Console.WriteLine(StartPage._searchRresults.Count);

            StartPage.Search("Tesla");

            Console.WriteLine(StartPage._searchRresults.Count);

            Console.WriteLine(StartPage.GetResult(0).GetTitle());
            Console.WriteLine(StartPage.GetResult(0).GetPrice());

            StartPage.GetResults().ForEach(item => 
                Console.WriteLine(item.GetTitle() + " \t" + item.GetPrice()));
        }
    }
}
