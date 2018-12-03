using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Algorithms.Traverse
{
    public class BacktrackLookup<T>
    {
        private readonly ISolution<T> _solution;

        public BacktrackLookup(ISolution<T> solution)
        {
            _solution = solution;
        }

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public IEnumerable<IEnumerable<T>> Backtrack(int[] vector, int k, IEnumerable<T> set)
        {
            var list = new List<IEnumerable<T>>();

            if (_solution.IsSolution(vector, k, set))
            {
                list.Add(_solution.GetSolution(vector, k, set));
            }
            else
            {
                k += 1;

                var candidates = _solution.ConstructCandidates(vector, k, set);
                
                foreach (var bit in candidates)
                {
                    vector[k] = bit;

                    _solution.MakeMove(vector, k, set);

                    list.AddRange(Backtrack(vector, k, set));

                    _solution.UnmakeMove(vector, k, set);
                }
            }

            return list;
        }
    }
}