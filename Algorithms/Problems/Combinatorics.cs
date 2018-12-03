using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Combinatorics;

namespace Algorithms.Problems
{
    public static class Combinatorics
    {
        public static void Run()
        {
            "Combinatorics tests".Header();

            Console.WriteLine("Inintiale set: {1, 2, 3, 4}");

            var array = new[] {1, 2, 3, 4};

            GetPowerSet(array);

            LexicographicallySorted(array);

            Recursive(array);

            NotRecursive(array);

            "Having [2, -2, 3, 0, 4, 7] find the count of times the subset of this set can be equal to 0".Header();
            SetPorblem1(new[] { 2, -2, 3, 0, 4, 7 }.ToList());
        }

        private static void SetPorblem1(List<int> list)
        {
            int count;

            if (list.Count >= 100000 && !list.Any(x => x >= 0))
            {
                count = -1;
            }
            else
            {
                count = list.GetPowerSet().Count(x => x.Sum() == 0);
            }

            Console.WriteLine($"Answer: {count}");
        }

        private static void GetPowerSet(IEnumerable<int> array)
        {
            "PowerSet".Header();

            foreach (var set in array.ToList().GetPowerSet())
            {
                PrintEnumerable(set);
            }
        }

        private static void NotRecursive(IEnumerable<int> array)
        {
            "Not recursive".Header();

            foreach (var combination in array.AllSubsets())
            {
                PrintEnumerable(combination);
            }
        }

        private static void Recursive(IEnumerable<int> array)
        {
            "Recursive".Header();

            foreach (var combination in array.AllSubsetsRecursive())
            {
                PrintEnumerable(combination);
            }
        }

        private static void LexicographicallySorted(IReadOnlyCollection<int> array)
        {
            "Lexicographically sorted".Header();

            for (var i = 0; i <= array.Count; i++)
            {
                foreach (var combination in array.Combinations(i))
                {
                    PrintEnumerable(combination);
                }
            }
        }

        private static void PrintEnumerable(IEnumerable<int> combination)
        {
            var ouput = string.Join(",", combination.Select(x => x.ToString()));
            Console.WriteLine($"({ouput})");
        }
    }
}