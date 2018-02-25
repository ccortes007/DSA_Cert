using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_3_test
{
    class GDC_3_test
    {
        static Int64 gcd_naive(Int64 a, Int64 b)
        {
            Int64 current_gcd = 1;
            for (Int64 d = 2; d <= a && d <= b; d++)
            {
                if (a % d == 0 && b % d == 0)
                {
                    if (d > current_gcd)
                    {
                        current_gcd = d;
                    }
                }
            }
            return current_gcd;
        }
        static Int64 gcd_fast(Int64 a, Int64 b)
        {
            if (b == 0)
                return a;
            Int64 ap = a % b;
            return gcd_fast(b, ap);
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
                a = _r.Next();
                b = _r.Next();
                naive = gcd_naive(a, b);
                fast = gcd_fast(a, b);
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
