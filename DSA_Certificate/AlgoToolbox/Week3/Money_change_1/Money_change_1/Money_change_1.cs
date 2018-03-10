using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_change_1
{
    class Money_change_1
    {
        static int change(int m)
        {
            int coins = 0;
            int c10 = 0;
            int c5 = 0;
            int c1 = 0;
            if (m == 1 | m == 5 | m == 10)
                return 1;
            c10 = m / 10;
            c5 = (m - (c10 * 10)) / 5;
            c1 = m - (c10 * 10) - (c5 * 5);
            coins = c10 + c5 + c1;
            return coins;
        }
        static void Main(string[] args)
        {
            var ns = Console.ReadLine();
            int m = int.Parse(ns);
            Console.WriteLine(change(m));
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }
    }
}
