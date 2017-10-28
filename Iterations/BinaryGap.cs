using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            string binaryRepresentation = Convert.ToString(N, 2);

            // search max binary gap
            int longestBinaryGap = 0;
            int binaryGapLenght = 0;
            for (int i = 1; i < binaryRepresentation.Length; i++)
            {
                if (binaryRepresentation[i - 1] == '1' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght = 1;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght++;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '1')
                {
                    longestBinaryGap = Math.Max(longestBinaryGap, binaryGapLenght);
                }
            }

            return longestBinaryGap;
        }

    }
}