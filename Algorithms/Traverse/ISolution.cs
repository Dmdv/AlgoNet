using System.Collections.Generic;

namespace AlgoNet.Algorithms.Traverse
{
    public interface ISolution<T>
    {
        bool IsSolution(int[] vector, int k,  IEnumerable<T> set);

        IEnumerable<T> GetSolution(int[] vector, int k, IEnumerable<T> set);

        IEnumerable<int> ConstructCandidates(int[] vector, int k, IEnumerable<T> set);

        void MakeMove(int[] vector, int k, IEnumerable<T> set);

        void UnmakeMove(int[] vector, int k, IEnumerable<T> set);
    }
}