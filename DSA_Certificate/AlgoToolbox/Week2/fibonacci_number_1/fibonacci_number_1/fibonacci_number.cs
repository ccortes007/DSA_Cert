using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_number_1
{
    class fibonacci_number
    {
        static Int64 calc_fibo (Int64 n)
        {
            if (n <= 1)
                return n;
            Int64 prev2 = 1;
            Int64 prev1 = 1;
            Int64 current = 2;
            for (Int64 i = 2; i <= n; i++)
            {
                current = prev2 + prev1;
                prev2 = prev1;
                prev1 = current;
            }
            return current;
        }
        static void Main(string[] args)
        {
            var ns = Console.ReadLine();
            Int64 n = Int64.Parse(ns);
            Console.WriteLine(calc_fibo(n));
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }
    }
}
