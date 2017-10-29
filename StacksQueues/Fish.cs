using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace CodeilityCSharp
{
    public class Fish
    {
        // A Fish 4,3,2,1,5
        // B    0,1,0,0,0
        public int solution(int[] A, int[] B)
        {
            var s = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                int size = A[i];
                int dir = B[i];
                if (s.Count == 0)
                {
                    s.Push(i);
                }
                else
                {
                    // 如果有存魚 且 目前的與行進方向為up down 且 現在這隻的Size 大於存活的
                    while (s.Count != 0 && dir - B[s.Peek()] == -1 && A[s.Peek()] < size)
                    {
                        s.Pop();
                    }
                    if (s.Count != 0)
                    {
                        if (dir - B[s.Peek()] != -1) 
                            s.Push(i);
                    }
                    else
                    {
                        s.Push(i);
                    }
                }
            }
            return s.Count;
        }

    }
}