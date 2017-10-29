using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            int[] sums = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                sums[i + 1] = sums[i] + A[i];
            }

            float minAvg = float.MaxValue;
            int minSliceIndex = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int i0 = i;
                int i1 = i + 1;
                float avg2 = (sums[i1 + 1] - sums[i0]) / 2.0f;

                if (avg2 < minAvg)
                {
                    minAvg = avg2;
                    minSliceIndex = i;
                }

                if (i < N - 2)
                {
                    int i2 = i + 2;
                    float avg3 = (sums[i2 + 1] - sums[i0]) / 3.0f;

                    if (avg3 < minAvg)
                    {
                        minAvg = avg3;
                        minSliceIndex = i;
                    }
                }
            }

            return minSliceIndex;
        }

    }
}