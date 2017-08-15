using System;

namespace AlgoNet.Algorithms.Combinatorics
{
    public class SubsetSolution : ISolution<int>
    {
        private readonly IOutput _output;

        public SubsetSolution(IOutput output)
        {
            _output = output;
        }

        public bool is_a_solution(int[] a, int k, int input)
        {
            return k == input;
        }

        public void process_solution(int[] a, int k, int input)
        {
            _output.Write(@"(");
            for (var i = 1; i <= k; i++)
            {
                if (a[i] == 1)
                {
                    _output.Write(a[i].ToString());
                }
            }
            _output.WriteLine(")");
        }

        public void construct_candidates(int[] a, int k, int input, int[] c, out int ncandidates)
        {
            c[0] = 1;
            c[1] = 0;
            ncandidates = 2;
        }

        public void make_move(int[] a, int k, int input)
        {
        }

        public void unmake_move(int[] a, int k, int input)
        {
        }
    }
}