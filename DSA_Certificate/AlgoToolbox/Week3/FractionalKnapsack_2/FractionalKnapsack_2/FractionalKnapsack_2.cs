using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalKnapsack_2
{
    class FractionalKnapsack_2
    {
        private static double getOptimalValue(int capacity, int[] values, int[] weights)
        {
            double cap = capacity;
            double value = 0;
            int n = values.Length;
            double[] kv = new double[n];
            double[] kw = new double[n];
            for (int i = 0; i < n; i++)
            {
                kv[i] = Convert.ToDouble(values[i]) / Convert.ToDouble(weights[i]);
                kw[i] = Convert.ToDouble(values[i]) / Convert.ToDouble(weights[i]);
            }
            Array.Sort(kv,values);
            Array.Sort(kw,weights);
            Array.Reverse(kv);
            Array.Reverse(values);
            Array.Reverse(kw);
            Array.Reverse(weights);
            for (int i = 0; i < n; i++)
            {
                if (cap == 0)
                    return value;
                double a = Math.Min(weights[i], cap);
                value = value + (a * (kv[i]));
                cap = cap - a;
            }
            return value;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var tokens = input.Split(' ');
            int n = int.Parse(tokens[0]);
            int capacity = int.Parse(tokens[1]);
            int[] values = new int[n];
            int[] weights = new int[n];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                tokens = input.Split(' ');
                values[i] = int.Parse(tokens[0]);
                weights[i] = int.Parse(tokens[1]);
            }
            Console.WriteLine("{0:F4}",getOptimalValue(capacity, values, weights));
        }
    }
}
