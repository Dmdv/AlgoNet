namespace AlgoNet.Algorithms.Traverse
{
    public interface ISolution<in T>
    {
        bool is_a_solution(int[] a, int k, T input);
        void process_solution(int[] a, int k, T input);
        void construct_candidates(int[] a, int k, T input, int[] c, out int ncandidates);
        void make_move(int[] a, int k, T input);
        void unmake_move(int[] a, int k, T input);
    }
}