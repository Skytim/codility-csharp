using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class CountFactors
    {
        public int solution(int N)
        {
           
            int numFactors = 0;
            for (int i = 1; i <= (double)Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i * i != N)
                    {
                        numFactors = numFactors + 2;
                    }
                    else if (i * i == N)
                    {
                        numFactors = numFactors + 1;
                    }
                }
            }
            return numFactors;
        }
    }
}