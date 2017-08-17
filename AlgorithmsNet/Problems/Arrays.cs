using System;
using System.Linq;

namespace AlgoNet.Problems
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine(" -- Arrays --");

            CycleShift();
        }

        private static void CycleShift()
        {
            const int K = 4;

            var source = new[] {1, 2, 3, 4, 5};
            var target = new int[source.Length];

            for (var i = 0; i < K; i++)
            {
                target[i] = source[(i + K) % source.Length];
            }

            Console.WriteLine(" -- Cycle shift of an array --");
            Console.WriteLine(string.Join(" ", target.Select(x => x.ToString())));
        }
    }
}