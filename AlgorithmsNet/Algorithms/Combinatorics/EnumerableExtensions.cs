using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace AlgoNet.Algorithms.Combinatorics
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Gets combinations from set by count
        /// </summary>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> set, int count)
        {
            return count == 0
                ? new[] {new T[0]}
                : set.SelectMany((e, i) =>
                    set.Skip(i + 1).Combinations(count - 1).Select(c => new[] {e}.Concat(c)));
        }

        // Построение решения Р(n) для общего случая.
        // Вычисляем Р(n-1), клонируем результаты и добавляем an в каждый из эти клонированных множеств

        /// <summary>
        /// Gets all subsets from the given set starting from index in set
        /// </summary>
        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        public static IEnumerable<IEnumerable<T>> AllSubsets<T>(this IEnumerable<T> set, int index = 0)
        {
            IEnumerable<IEnumerable<T>> allSubsets;

            if (set.Count() == index)
            {
                allSubsets = new List<IEnumerable<T>> {new List<T>()}; // добавить пустое множество в базовом случае
            }
            else
            {
                allSubsets = AllSubsets(set, index + 1).ToArray();

                var item = set.ElementAt(index);

                var moreSubsets = new List<IEnumerable<T>>();

                foreach (var subset in allSubsets)
                {
                    var newSet = new List<T>();
                    newSet.AddRange(subset);
                    newSet.Add(item);
                    moreSubsets.Add(newSet);
                }

                allSubsets = allSubsets.Concat(moreSubsets);
            }

            return allSubsets;
        }
    }
}