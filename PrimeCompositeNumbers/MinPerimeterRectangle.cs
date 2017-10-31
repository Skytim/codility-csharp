using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            int minPer = int.MaxValue;

            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    minPer = Math.Min(minPer, 2 * (N / i + i));
                }
            }

            return minPer;
        }

    }
}