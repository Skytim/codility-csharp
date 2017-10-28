using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class PermMissingElem
    {
        public int solution(int[] N)
        {
            long n = N.Length + 1;
            var sumOfAllElements = (n * (1 + n)) / 2;
            var missingElement = sumOfAllElements - N.Select(x => (long)x).Sum();
            return (int)missingElement;
        }

    }
}