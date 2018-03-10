using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Advertisement_Revenue_3
{
    class DotProduct
    {
        private static double getOptimalValue(int[] values, int[] weights)
        {
            double value = 0;
            int n = values.Length;
            Array.Sort(values);
            Array.Reverse(values);
            Array.Sort(weights);
            Array.Reverse(weights);
            for (int i = 0; i < n; i++)
            {
                value = value + (values[i] * weights[i]);
            }
            return value;
        }
        static void Main(string[] args)
        {
            var ns = Console.ReadLine();
            int n = int.Parse(ns);
            int[] values = new int[n];
            int[] weights = new int[n];
            var inputv = Console.ReadLine();
            var tokensv = inputv.Split(' ');
            var inputw = Console.ReadLine();
            var tokensw = inputw.Split(' ');
            for (int i = 0; i < n; i++)
            {
                if (tokensv[i].Substring(0,1) == "-")
                {
                    values[i] = int.Parse(tokensv[i].Substring(1, (tokensv[i].Length) - 1)) * -1;
                }
                else
                    values[i] = int.Parse(tokensv[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (tokensw[i].Substring(0, 1) == "-")
                {
                    weights[i] = int.Parse(tokensw[i].Substring(1, (tokensw[i].Length) - 1)) * -1;
                }
                else
                    weights[i] = int.Parse(tokensw[i]);
            }
            Console.WriteLine("{0}", getOptimalValue(values, weights));
            //Console.Write("Press any key to continue");
            //Console.ReadLine();
        }
    }
}
