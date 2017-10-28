using System;

namespace CodeilityCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:"); // Prompt
            string line = Console.ReadLine(); // Get string from use
            if (line == "1")
            {
                var binaryGap = new BinaryGap();
                Console.WriteLine(binaryGap.solution(9));
                Console.WriteLine(binaryGap.solution(12320));
            }
            if (line == "2")
            {
                int[] A = { 9, 3, 9, 3, 9, 7, 9 };
                var OddOccurencleArray = new OddOccurrencesInArray();
                Console.WriteLine(OddOccurencleArray.solution(A));
            }
             if (line == "3")
            {
                int[] A = { 3, 1, 2, 4, 3 };
                var OddOccurencleArray = new TapeEquilibrium();
                Console.WriteLine(OddOccurencleArray.solution(A));
            }
             if (line == "4")
            {
                int[] A = { 3, 8, 9, 7, 6 };
                var OddOccurencleArray = new CyclicRotation();
                Console.WriteLine(OddOccurencleArray.solution(A,3));
            }
        }
    }
}
