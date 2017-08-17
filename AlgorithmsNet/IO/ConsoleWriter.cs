using System;

namespace AlgoNet.IO
{
    public class ConsoleWriter : IOutput
    {
        public void Write(string format, params object[] args)
        {
            Console.Write(format, args);
        }

        public void WriteLine(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }
    }
}