using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Num_of_Prizes_5
{

    class DifferentSummands
    {
        private static List<int> optimalSummands(int n)
        {
            List<int> summands = new List<int>();
            int i = 1;
            int j = n;
            while (true)
            {
                //Console.WriteLine("i=[{0}] j=[{1}]", i, j);
                if ((2 * i) < j)
                {
                    summands.Add(i);
                    j = j - i;
                    i = i + 1;
                }
                else
                {
                    summands.Add(j);
                    break;
                }
            }
            return summands;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> summands = optimalSummands(n);
            Console.WriteLine(summands.Count);
            foreach (int summand in summands)
            {
                Console.Write("{0} ", summand);
            }
            Console.WriteLine();
            //Console.WriteLine("Press any key to continue");
            //Console.ReadLine();
        }
    }
}
