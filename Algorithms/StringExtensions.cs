using System;

namespace Algorithms
{
    public static class StringExtensions
    {
        public static void Header(this string header)
        {
            int width = header.Length < 80 ? 80 : header.Length + 20;

            var fieldWidth = (width - header.Length) / 2;
            var field = new string('-', fieldWidth);

            Console.WriteLine();
            Console.WriteLine($"{field}{header}{field}");
            Console.WriteLine();
        }
    }
}