using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class CountDiv
    {
        public int solution(int A, int B, int K)
        {
            return B / K - (A / K) + (A % K == 0 ? 1 : 0);
        }

    }
}