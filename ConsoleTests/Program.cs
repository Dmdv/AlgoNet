using System;
using Algorithms.Problems;

namespace ConsoleTests
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Arrays.Run();
            Combinatorics.Run();
            BigNumber.Run();
            Console.WriteLine("All tests are completed");
            Console.ReadLine();
        }
    }
}