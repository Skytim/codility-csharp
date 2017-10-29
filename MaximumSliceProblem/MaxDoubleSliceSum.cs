using System;
using System.Collections;
using System.Collections.Generic;
namespace CodeilityCSharp
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {

            if (A.Length < 4)
            {
                return 0;
            }

            // get starting max slice
            int[] endingMaxSum = new int[A.Length];
            for (int i = 1; i < A.Length; i++)
            {
                endingMaxSum[i] = Math.Max(0, endingMaxSum[i - 1] + A[i]);
            }

            // get ending max slice
            int[] startingMaxSum = new int[A.Length];
            for (int i = A.Length - 2; i >= 0; i--)
            {
                startingMaxSum[i] = Math.Max(0, startingMaxSum[i + 1] + A[i]);
            }

            // find max
            int maxDoubleSlice = 0;
            for (int i = 0; i < A.Length - 2; i++)
            {
                maxDoubleSlice = Math.Max(maxDoubleSlice, endingMaxSum[i] + startingMaxSum[i + 2]);
            }

            return maxDoubleSlice;
        }
    }
}