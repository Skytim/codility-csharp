using System;
namespace CodeilityCSharp
{
    public class FloodDepth
    {
        public int solution(int[] A)
        {
            int highestIdx = 0;
            int lowestIdx = 0;
            int max = 0;

            for (int i = 1; i < A.Length; i++)
            {
                int current = A[i];
                int highest = A[highestIdx];
                int lowest = A[lowestIdx];
                if (current > highest)
                {
                    max = Math.Max(highest - lowest, max);
                    highestIdx = i;
                    lowestIdx = i;
                }
                else if (current > lowest)
                {
                    max = Math.Max(current - lowest, max);
                }
                else if (current < lowest)
                {
                    lowestIdx = i;
                }
            }
            return max;
        }
    }
}