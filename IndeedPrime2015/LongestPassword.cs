using System;
namespace CodeilityCSharp
{
    public class LongestPassword
    {
        public int solution(string S)
        {
            var longest = -1;
            var num_of_letters = 0;
            var num_of_digits = 0;
            var num_of_others = 0;
            foreach (var word in S)
            {
                if (Char.IsLetter(word))
                {
                    num_of_letters += 1;
                }

                else if (Char.IsDigit(word))
                {
                    num_of_digits += 1;
                }
                else if (word == ' ')
                {
                    // Check whether it's a valid password.
                    if (num_of_others == 0 && num_of_letters % 2 == 0 && num_of_digits % 2 == 1)
                    {
                        if (longest < num_of_letters + num_of_digits)
                        {
                            longest = num_of_letters + num_of_digits;
                        }
                    }
                    // Reset the counters for the next word.
                    num_of_letters = 0;
                    num_of_digits = 0;
                    num_of_others = 0;
                }
                else
                {
                    num_of_others += 1;
                }
            }
            //Check whether the last word is a valid password.
            if (num_of_others == 0 && num_of_letters % 2 == 0 && num_of_digits % 2 == 1)
            {
                if (longest < num_of_letters + num_of_digits)
                {
                    longest = num_of_letters + num_of_digits;
                }
            }
            return longest;
        }
    }
}