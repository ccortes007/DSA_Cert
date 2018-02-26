using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_mod_5_test
{
    class fibonacci_mod_5_test
    {
        static Int64 calc_fibo_mod_naive(Int64 n, Int64 m)
        {
            if (n <= 1)
                return n;
            Int64 prev2 = 0;
            Int64 prev1 = 1;
            Int64 current = 2;
            for (Int64 i = 2; i <= n; i++)
            {
                current = (prev2 + prev1) % m;
                prev2 = prev1;
                prev1 = current;
            }
            return current;
        }
        static Random _r = new Random();
        static void Main(string[] args)
        {
            Int64 naive = 0;
            Int64 fast = 0;
            Int64 n = 0;
            Int64 m = 0;
            while (true)
            {
                n = _r.Next(100000000) + 1;
                m = _r.Next(100000) + 1;
                naive = calc_fibo_mod_naive(n, m);
                fast = calc_fibo_mod_naive(n, m);
                Console.Write("f_naive({0},{1}) = {2} f_fast({3},{4}) = {5} ", n, m, naive, n,m, fast);
                if (naive == fast)
                    Console.WriteLine("OK");
                else
                {
                    Console.WriteLine("Error");
                    break;
                }
            }
            Console.WriteLine("<Press any key to continue>");
            Console.ReadLine();

        }
    }
}
