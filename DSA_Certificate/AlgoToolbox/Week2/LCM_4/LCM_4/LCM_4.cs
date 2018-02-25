using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCM_4
{
    class LCM_4
    {
        static Int64 gcd_fast(Int64 a, Int64 b)
        {
            if (b == 0)
                return a;
            Int64 ap = a % b;
            return gcd_fast(b, ap);
        }
        static Int64 lmc_fast(Int64 a, Int64 b)
        {
            return ((a * b) / gcd_fast(a, b));
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            Int64 a = Int64.Parse(tokens[0]);
            Int64 b = Int64.Parse(tokens[1]);
            Console.WriteLine(lmc_fast(a, b));
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }
    }
}
