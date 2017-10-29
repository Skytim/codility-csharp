using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class Triangle
    {
        public int solution(int[] A)
        {

            var A_length = A.Length;
            if (A_length < 3)
                return 0;
            Array.Sort(A);
            for (var i = 0; i < A_length - 2; i++)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}