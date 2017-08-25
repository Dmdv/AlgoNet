using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AlgoNet.Algorithms.Traverse
{
    public class SubsetSolution<T> : ISolution<T>
    {
        public bool IsSolution(int[] vector, int k, IEnumerable<T> set)
        {
            return k == vector.Length - 1;
        }

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public IEnumerable<T> GetSolution(int[] vector, int k, IEnumerable<T> set)
        {
            // TODO: just enumerate through vector and remove k

            var subset = new List<T>();

            for (var i = 0; i <= k; i++)
            {
                if (vector[i] == 1)
                {
                    subset.Add(set.ElementAt(i));
                }
            }

           return subset;
        }

        public IEnumerable<int> ConstructCandidates(int[] vector, int k, IEnumerable<T> set)
        {
            return new List<int> {1, 0};
        }

        public void MakeMove(int[] vector, int k, IEnumerable<T> set)
        {
        }

        public void UnmakeMove(int[] vector, int k, IEnumerable<T> set)
        {
        }
    }
}