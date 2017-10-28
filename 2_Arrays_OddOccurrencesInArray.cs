using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            var oddValue = A
                .GroupBy(e => e)
                .Where(e => e.Count() % 2 != 0)
                .Select(e => e.FirstOrDefault());

            return oddValue.FirstOrDefault();
        }

    }
}