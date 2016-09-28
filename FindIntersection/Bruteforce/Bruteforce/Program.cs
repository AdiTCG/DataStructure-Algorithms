using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    class Program
    {
        static void Main(string[] args)
        {
            //populateData
            Console.WriteLine("Enter the range");
            var val = Convert.ToInt32(Console.ReadLine());

            int[] in1 = new int[val], in2 = new int[val];

            for (int i = 0; i < val; i++)
            {
                in1[i] = i;
                in2[i] = i + val;
            }
            var start = DateTime.Now;
            Console.WriteLine(Solver.FindIntersection(in1, in2));
            Console.Write("Time taken: ");
            Console.WriteLine(DateTime.Now - start);
        }
    }
}
