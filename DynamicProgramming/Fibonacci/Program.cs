using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
        // O(2^n)
        //Fibonacci using recursion
        static int GetFibonacci(int n)
        {
            //base case
            if (n < 3) return 1;

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }*/

        //O(n) 
        //Memorize sub problem once it is executed.
        //Calculate each sub problem once
        static long GetFibonacci(int n, long[] memory)
        {
            //base case
            if (n < 3) return 1;
            if (memory[n] > 0)
                return memory[n];

            memory[n] = GetFibonacci(n - 1, memory) + GetFibonacci(n - 2, memory);
            return memory[n];
        }

        //Driver program
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = Convert.ToInt32( Console.ReadLine());

            //call
            long[] mem = new long[n + 1];
            long r = GetFibonacci(n, mem);
            Console.WriteLine(r);
        }
    }
}
