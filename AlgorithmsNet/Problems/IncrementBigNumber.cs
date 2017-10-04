using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoNet.Problems
{
    public class BigNumber
    {
        public static void Run()
        {
            Print("999");
            Print("9999");
            Print("889");
            Print((int.MaxValue - 1).ToString());
            Print(int.MaxValue.ToString());
            Print("1299999999999999999999");
            Print("1289999999999999999999");
            Print("128787685675745648568757647549999999999999999999");
        }

        private static void Print(string str)
        {
            var number = new BigNumber();
            Console.WriteLine("{0} ->", str);
            Console.WriteLine(number.SuperIncrement(str));
        }

        public string SuperIncrement(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "1";
            }

            var leftPart = input.Substring(0, input.Length - 1);
            var rightChar = input.Substring(input.Length - 1, 1);
            
            int intChar;

            if (!int.TryParse(rightChar, out intChar))
                throw new ArgumentException("String contains non numeric character");

            intChar++;

            if (intChar == 10)
            {
                leftPart = SuperIncrement(leftPart);
                intChar = 0;
            }

            return leftPart + intChar;
        }

        public string Increment(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return "1";
            }

            var arr = number.ToCharArray();

            int i;

            for (i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == '9')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (arr.Last() == '9')
            {
                var str = number.Substring(0, i + 1);
                var sb = new StringBuilder();
                sb.Append('0', number.Length - i - 1);
                return Increment(str) + sb.ToString();
            }

            var first = number.Substring(0, i);
            var second = number.Substring(i);

            int num;
            var result = int.TryParse(second, out num);
            if (!result)
            {
                var str = Increment(second);
            }
            num++;

            return first + num.ToString();
        }
    }
}
