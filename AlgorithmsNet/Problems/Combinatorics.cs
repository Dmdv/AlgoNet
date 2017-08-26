using AlgoNet.Algorithms.Combinatorics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoNet.Problems
{
    public static class Combinatorics
    {
        public static void Run()
        {
            Console.WriteLine("---------------------- Combinatorics ---");

            var array = new[] {1, 2, 3, 4};

            LexicographicallySorted(array);

            Recursive(array);

            NotRecursive(array);
        }

        private static void NotRecursive(IEnumerable<int> array)
        {
            Console.WriteLine("----- Not recursive ---");

            foreach (var combination in array.AllSubsets())
            {
                var ouput = string.Join(",", combination.Select(x => x.ToString()));
                Console.WriteLine($"({ouput})");
            }
        }

        private static void Recursive(IEnumerable<int> array)
        {
            Console.WriteLine("----- Recursive ---");

            foreach (var combination in array.AllSubsetsRec())
            {
                var ouput = string.Join(",", combination.Select(x => x.ToString()));
                Console.WriteLine($"({ouput})");
            }
        }

        private static void LexicographicallySorted(IReadOnlyCollection<int> array)
        {
            Console.WriteLine("----- Lexicographically sorted ---");

            for (var i = 0; i <= array.Count; i++)
            {
                foreach (var combination in array.Combinations(i))
                {
                    var ouput = string.Join(",", combination.Select(x => x.ToString()));
                    Console.WriteLine($"({ouput})");
                }
            }
        }
    }
}