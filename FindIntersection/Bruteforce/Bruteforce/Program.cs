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
            var range = Convert.ToInt32(Console.ReadLine());

            int[] in1 = new int[range], in2 = new int[range];
            //Random r = new Random();

            for (int i = 0; i < range; i++)
            {
                in1[i] = i;//r.Next(0, range);
                in2[i] = i + range;
            }

            var start = DateTime.Now;
            Console.WriteLine(Solver.FindIntersection2(in1, in2));
            Console.Write("Time taken: ");
            Console.WriteLine(DateTime.Now - start);
            Console.Read();
        }
    }
}
