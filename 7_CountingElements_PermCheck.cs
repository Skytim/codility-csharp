using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class PermCheck
    {
        public int solution(int[] N)
        {
            // idea: add to set,dictionary. Count the size and compare to N.
            // dedupe data when needed. 
            var set = new HashSet<int>();
            var max = int.MinValue;

            foreach (var item in N)
            {
                if (set.Contains(item)) return 0;

                set.Add(item);
                if (item > max) max = item;
            }
            return set.Count == max ? 1 : 0;
        }

    }
}