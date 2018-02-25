using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM_4_Test
{
    class LCM_4_Test
    {
        static Int64 lmc_naive(Int64 a ,Int64 b)
        {
            for (Int64 i = 1; i <= a * b; i++)
                if (i % a == 0 && i % b == 0)
                    return i;

            return a * b;
        }
        static Int64 gcd_fast(Int64 a, Int64 b)
        {
            if (b == 0)
                return a;
            Int64 ap = a % b;
            return gcd_fast(b, ap);
        }
        static Int64 lmc_fast(Int64 a, Int64 b)
        {
            return ((a*b) / gcd_fast(a,b));
        }
        static Random _r = new Random();
        static void Main(string[] args)
        {
            Int64 naive = 0;
            Int64 fast = 0;
            Int64 a = 0;
            Int64 b = 0;
            while (true)
            {
                a = _r.Next(50000) + 1;
                b = _r.Next(50000) + 1;
                naive = lmc_naive(a, b);
                fast = lmc_fast(a, b);
                Console.Write("a = [{0}] ,b = [{1}] ,naive = [{2}] ,fast = [{3}] ", a, b, naive, fast);
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
