using System.Collections.Generic;
using Algorithms.Traverse;
using Xunit;

namespace UnitTests
{
    public class GenerateSubsetTests
    {
        [Fact]
        public void TestSubsets()
        {
            var lookup = new BacktrackLookup<int>(new SubsetSolution<int>());

            var set = new List<int> {1, 2, 3, 4};
            var vector = new int[set.Count];

            var enumerable = lookup.Backtrack(vector, -1, set);
        }
    }
}
