﻿using System;
using System.Linq;

namespace AlgoNet.Problems
{
    public static class Arrays
    {
        public static void Run()
        {
            Console.WriteLine(" ------------------- Arrays ---");

            CycleShift();
        }

        private static void CycleShift()
        {
            const int K = 4;

            var source = new[] {1, 2, 3, 4, 5};
            var target = new int[source.Length];

            for (var i = 0; i < source.Length; i++)
            {
                target[(i + K) % source.Length] = source[i];
                //target[i] = source[(i + K) % source.Length];
            }

            Console.WriteLine(" ----- Cycle shift of an array by 4 ---");
            Console.Write("Source: ");
            Console.WriteLine(string.Join(" ", source.Select(x => x.ToString())));
            Console.Write("Target: ");
            Console.WriteLine(string.Join(" ", target.Select(x => x.ToString())));
        }
    }
}
