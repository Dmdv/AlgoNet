using System;

namespace AlgoNet.Types.Graphs
{
    public class Edge<T, TVal> : IEquatable<Edge<T, TVal>>
    {
        public TVal Dist { get; set; }
        public T From { get; set; }
        public T To { get; set; }

        public bool Equals(Edge<T, TVal> other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(other.From, From) && Equals(other.To, To);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Edge<T, TVal>)) return false;
            return Equals((Edge<T, TVal>) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (From.GetHashCode() * 397) ^ To.GetHashCode();
            }
        }

        public static bool operator ==(Edge<T, TVal> left, Edge<T, TVal> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Edge<T, TVal> left, Edge<T, TVal> right)
        {
            return !Equals(left, right);
        }
    }
}