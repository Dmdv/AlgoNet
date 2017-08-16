using AlgoNet.Algorithms.Combinatorics;
using AlgoNet.IO;
using System;
using System.Linq;

namespace ConsoleTests
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var array = new[] {1, 2, 3, 4};

            for (var i = 0; i <= array.Length; i++)
            {
                foreach (var combination in array.Combinations(i))
                {
                    var ouput = string.Join(",", combination.Select(x => x.ToString()));
                    Console.WriteLine($"({ouput})");
                }
            }

            Console.WriteLine("---------- AllSubsetsRec -----------");

            foreach (var combination in array.AllSubsetsRec())
            {
                var ouput = string.Join(",", combination.Select(x => x.ToString()));
                Console.WriteLine($"({ouput})");
            }

            Console.WriteLine("---------- AllSubsets -----------");

            foreach (var combination in array.AllSubsets())
            {
                var ouput = string.Join(",", combination.Select(x => x.ToString()));
                Console.WriteLine($"({ouput})");
            }

            Console.ReadLine();
        }

        private static void Test1()
        {
            var lookup = new BacktrackLookup<int>(new SubsetSolution(new ConsoleWriter()));

            var a = new int[1024];

            lookup.Backtrack(a, 0, 2);
        }
    }
}