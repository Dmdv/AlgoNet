namespace AlgoNet.Types.Graphs
{
    public class Vertex<T>
    {
        public Vertex()
        {
            Dist = int.MaxValue;
            Prev = null;
            Value = default(T);
        }

        public Vertex(T value)
        {
            Dist = int.MaxValue;
            Prev = null;
            Value = value;
        }

        public int Dist { get; set; }
        public Vertex<T> Prev { get; set; }
        public T Value { get; set; }
    }
}