using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            var distance = Y - X;
            if (distance % D == 0)
                return distance / D;
            else
                return distance / D + 1;
        }
    }
}