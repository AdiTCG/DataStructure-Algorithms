using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        //Fibonacci using recursion
        static int GetFibonacci(int n)
        {
            //base case
            if (n < 3) return 1;

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        //Driver program
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }
    }
}
