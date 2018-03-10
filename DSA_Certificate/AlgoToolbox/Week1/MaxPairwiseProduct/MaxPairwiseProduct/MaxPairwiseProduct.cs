using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairwiseProduct
{
    class MaxPairwiseProduct
    {
        static Int64 pwp (Int64[] numbers)
        {
            Int64 result = 0;
            Int64 max1 = Int64.MinValue;
            Int64 max2 = Int64.MinValue;
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] > max1)
                {
                    max2 = max1;
                    max1 = numbers[i];
                }
                //else if (max1 > numbers[i] & numbers[i] > max2) max2 = numbers[i];
                else if (numbers[i] > max2) max2 = numbers[i];
            }
            result = max1 * max2;
            return result;
        }
        static void Main(string[] args)
        {
            var ns = Console.ReadLine();
            Int64 n = Int64.Parse(ns);
            Int64[] num = new Int64[n];
            var input = Console.ReadLine();
            var tokens = input.Split(' '); 
            for (Int64 i=0; i<n; i++)
            {
                num[i] = Int64.Parse(tokens[i]);
            }
            Int64 res = pwp(num);
            Console.WriteLine(res);
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
            return;
        }
    }
}
