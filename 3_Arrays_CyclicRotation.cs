using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            int N = A.Length;
            if (N == 0)
                return A;
            if (K >= N)
                K %= N;
            if (K == 0)
                return A;
            int[] rotA = new int[N];
            for (int i = 0; i < N; i++)
                rotA[i] = (i < K) ? A[N + i - K] : A[i - K];
            return rotA;
        }

    }
}