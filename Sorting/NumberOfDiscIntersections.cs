using System;
using System.Collections.Generic;
namespace CodeilityCSharp
{
    public class NumberOfDiscIntersections
    {
        
        public int solution(int[] A)
        {
            int N = A.Length;
            //The array AX counts how many times a line (or circle) starts before or at the index. I.e. at position 0, 4 lines (or circles) have their starting point before or at 0.
            long[] AX = new long[N];
            //The array AY counts how many times a line (or circle) ends at the index. I.e. at position 0 no line (or circle) ends there. At position 1, one line (or circle) ends.
            long[] AY = new long[N];

            for (int i = 0; i < N; i++)
            {
                AX[Math.Max(0, i - A[i])]++;
                AY[Math.Min(N - 1, i + A[i])]++;
            }
            long result = 0;
            long discsAtIndex = 0;
            for (int i = 0; i < N; i++)
            {
                if (AX[i] > 0)
                {
                    result += discsAtIndex * AX[i] + (AX[i] * (AX[i] - 1) / 2);

                    discsAtIndex += AX[i];
                }
                discsAtIndex -= AY[i];
            }
            if (result <= 10000000)
                return (int)result;
            else return -1;
        }
    }
}