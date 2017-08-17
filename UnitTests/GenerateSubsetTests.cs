using AlgoNet.Algorithms.Combinatorics;
using AlgoNet.Algorithms.Traverse;
using AlgoNet.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class GenerateSubsetTests
    {
        [TestMethod]
        public void TestSubsets()
        {
            var lookup = new BacktrackLookup<int>(new SubsetSolution(new ConsoleWriter()));

            var a = new int[1024];

            lookup.Backtrack(a, 0, 1);
        }
    }
}
