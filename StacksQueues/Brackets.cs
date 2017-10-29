using System;
using System.Collections;
using System.Collections.Generic;
namespace CodeilityCSharp
{
    public class Brackets
    {
        public int solution(string S)
        {

            var matched = new Dictionary<string, string>();
            matched.Add("]", "[");
            matched.Add("}", "{");
            matched.Add(")", "(");

            var to_push = new List<string>();
            to_push.Add("[");
            to_push.Add("{");
            to_push.Add("(");

            Stack stack = new Stack();

            foreach (char c in S)
            {
                if (to_push.Contains(c.ToString()))
                    stack.Push(c.ToString());
                else
                    if (stack.Count == 0)
                    return 0;
                else if (!stack.Pop().Equals(matched[c.ToString()]))
                {
                    return 0;
                }
            }

            if (stack.Count == 0)
                return 1;

            return 0;
        }
    }
}