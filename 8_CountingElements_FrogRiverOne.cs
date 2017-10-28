using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            bool[] leavesInPosition = new bool[X + 1];
            int occupiedPositions = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i];
                if (position <= X && !leavesInPosition[position])
                {
                    leavesInPosition[position] = true;
                    occupiedPositions++;
                }
                if (occupiedPositions == X)
                {
                    return i;

                }
            }
            return -1;

        }

    }
}