namespace AlgoNet.Algorithms.Combinatorics
{
    public interface IOutput
    {
        void Write(string format, params object[] args);

        void WriteLine(string format, params object[] args);
    }
}