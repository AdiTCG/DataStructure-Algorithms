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
    }
}
