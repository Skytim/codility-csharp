using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int count = 0; // how many going east 
            int multiply = 0;// total passing pairs
            foreach (int car in A)
            {
                if (car == 0)
                {
                    multiply = multiply + 1;
                }
                if (multiply > 0)
                {
                    if (car == 1)
                    {
                        count = count + multiply;
                        if (count > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }
            return count;
        }

    }
}