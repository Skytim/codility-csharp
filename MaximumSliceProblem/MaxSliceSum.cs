using System;
using System.Collections;
using System.Collections.Generic;
namespace CodeilityCSharp
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            var max_ending = -1000000;
            var max_slice = -1000000;
            foreach (var a in A)
            {
                max_ending = Math.Max(a, max_ending + a);
                max_slice = Math.Max(max_slice, max_ending);
            }
            return max_slice;
        }
    }
}