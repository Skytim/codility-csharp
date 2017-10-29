using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class Distinct
    {
        public int solution(int[] A)
        {

            Array.Sort(A);
            int k = 1;
            for (var i = 0; i <= A.Length - 2; i++)
            {
                if (A[i] != A[i + 1])
                {
                    k = k + 1;
                };
            }

            return k;
        }
    }
}