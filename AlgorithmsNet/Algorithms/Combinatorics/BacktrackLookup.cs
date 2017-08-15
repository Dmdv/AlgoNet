namespace AlgoNet.Algorithms.Combinatorics
{
    public class BacktrackLookup<T>
    {
        private const int Max = 1024;

        private readonly ISolution<T> _solution;

        public BacktrackLookup(ISolution<T> solution)
        {
            _solution = solution;
        }

        public void Backtrack(int[] a, int k, T input)
        {
            // кандидаты для следующей позиции
            var c = new int[Max];

            if (_solution.is_a_solution(a, k, input))
            {
                _solution.process_solution(a, k, input);
            }
            else
            {
                k += 1;

                // количество кандидатов на следующую позицию
                int ncandidates;

                _solution.construct_candidates(a, k, input, c, out ncandidates);

                for (var i = 0; i < ncandidates; i++)
                {
                    a[k] = c[i];

                    _solution.make_move(a, k, input);
                    Backtrack(a, k, input);
                    _solution.unmake_move(a, k, input);
                }
            }
        }
    }
}