namespace CodeilityCSharp
{
    public class Nesting
    {
        public int solution(string S)
        {

            int result = 0;
            foreach (char element in S)
            {
                if (element == '(')
                {
                    result += 1;
                }
                else
                {
                    result -= 1;
                    if (result < 0) return 0;
                }
            }
            return result == 0 ? 1 : 0;
        }
    }
}