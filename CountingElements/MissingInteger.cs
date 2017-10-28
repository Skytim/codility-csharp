using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class MissingInteger
    {
        const int maxSize = 100000;

        public int solution(int[] A)
        {
            var counter = new bool[maxSize];

            foreach (var number in A)
            {
                if (number > 0 && number <= maxSize)
                {
                    counter[number - 1] = true;
                }
            }

            for (int i = 0; i < maxSize; i++)
            {
                if (counter[i] == false)
                {
                    return i + 1;
                }
            }

            return maxSize + 1;
        }

    }
}