using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            if (A.Length == 1 || A.Length == 0)
            {
                return 0;
            }

            int maxSoFar = 0;
            int maxEndingHere = 0;
            int minPrice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                maxEndingHere = Math.Max(0, A[i] - minPrice);
                minPrice = Math.Min(minPrice, A[i]);
                maxSoFar = Math.Max(maxEndingHere, maxSoFar);
            }

            return maxSoFar;
        }

    }
}