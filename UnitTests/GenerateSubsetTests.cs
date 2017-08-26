using AlgoNet.Algorithms.Traverse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class GenerateSubsetTests
    {
        [TestMethod]
        public void TestSubsets()
        {
            var lookup = new BacktrackLookup<int>(new SubsetSolution<int>());

            var set = new List<int> {1, 2, 3, 4};
            var vector = new int[set.Count];

            var enumerable = lookup.Backtrack(vector, -1, set);
        }
    }
}
