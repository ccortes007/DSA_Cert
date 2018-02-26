using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_number_1_test
{
    class fibonacci_number_test
    {
        static Int64 calc_fibo_naive(Int64 n)
        {
            if (n <= 1)
                return n;

            return calc_fibo_naive(n - 1) + calc_fibo_naive(n - 2);
        }
        static Int64 calc_fibo_fast(Int64 n)
        {
            if (n <= 1)
                return n;
            Int64 prev2 = 0;
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
            Int64 naive;
            Int64 fast;
            Int64 i = 0;
            while (i < 46)
            {
                Console.WriteLine("Running {0}", i);
                naive = calc_fibo_naive(i);
                fast = calc_fibo_fast(i);
                if (naive != fast)
                {
                    Console.WriteLine("naive [{0}] != fast [{1}]", naive, fast);
                    break;
                }
                i++;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
