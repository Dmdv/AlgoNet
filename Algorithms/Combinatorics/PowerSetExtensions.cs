using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Combinatorics
{
    public static class PowerSetExtensions
    {
        public static IEnumerable<IEnumerable<T>> GetPowerSet<T>(this List<T> list)
        {
            return
                from m in Enumerable.Range(0, 1 << list.Count)
                select
                    from i in Enumerable.Range(0, list.Count)
                    where (m & (1 << i)) != 0
                    select list[i];
        }

        /// <summary>
        /// An alternative implementation for an arbitrary number of elements:
        /// </summary>
        public static IEnumerable<IEnumerable<T>> GetPowerSet2<T>(this IEnumerable<T> input)
        {
            var seed = new List<IEnumerable<T>> {Enumerable.Empty<T>()} as IEnumerable<IEnumerable<T>>;

            return input.Aggregate(
                seed,
                (a, b) =>
                    a.Concat(a.Select(x => x.Concat(new List<T> {b}))));
        }
    }
}