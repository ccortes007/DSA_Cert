using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairwiseProductTest
{
    class MaxPairwiseProductTest
    {
        static Int64 mpwpSlow(Int64[] numbers)
        {
            Int64 result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] * numbers[j] > result)
                    {
                        result = numbers[i] * numbers[j];
                    }
                }

            }
            return result;
        }
        static Int64 mpwp(Int64[] numbers)
        {
            Int64 result = 0;
            Int64 max1 = Int64.MinValue;
            Int64 max2 = Int64.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max1)
                {
                    max2 = max1;
                    max1 = numbers[i];
                }
                else if (numbers[i] > max2) max2 = numbers[i];
            }
            result = max1 * max2;
            return result;
        }
        static Random _r = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                int n = (_r.Next() % 20) + 2;
                Int64[] num = new Int64[n];
                for (int i=0; i<num.Length; i++)
                {
                    num[i] = _r.Next() % 100000;
                }
                Int64 res_slow = mpwpSlow(num);
                Int64 res_fast = mpwp(num);
                Console.WriteLine(n);
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
                if (res_slow == res_fast)
                    Console.WriteLine("OK");
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
