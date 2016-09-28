using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruteforce
{
    static class Solver
    {
        internal static int FindIntersection(int[] p_Array1, int[] p_Array2)
        {
            int result = 0;
            for (int i = 0; i < p_Array1.Length; i++)
            {
                for (int j = 0; j < p_Array2.Length; j++)
                {
                    if (p_Array1[i] == p_Array2[j])
                    {
                        ++result;
                        break;
                    }
                }
            }
            return result;
        }

        internal static int FindIntersection2(int[] p_Array1, int[] p_Array2)
        {
            int result = 0;
            Array.Sort(p_Array1);//O(n Log n)
            for (int i = 0; i < p_Array1.Length; i++)
            {
                //O(n * Log n)
                //int d = -1;
                //if ( (d = Array.BinarySearch(p_Array2, p_Array1[i])) >= 0)
                if (Array.BinarySearch(p_Array2, p_Array1[i]) >= 0)
                {
                    result++;
                    //Console.WriteLine(p_Array2[d]);
                    break;
                }
            }
            return result;
        }
    }
}
