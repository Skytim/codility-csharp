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
                var oddOccurencleArray = new OddOccurrencesInArray();
                Console.WriteLine(oddOccurencleArray.solution(A));
            }
            if (line == "3")
            {
                int[] A = { 3, 8, 9, 7, 6 };
                var cyclicRotation = new CyclicRotation();
                Console.WriteLine(cyclicRotation.solution(A, 3));
            }
            if (line == "4")
            {
                int[] A = { 2, 3, 1, 5 };
                var permMissingElem = new PermMissingElem();
                Console.WriteLine(permMissingElem.solution(A));
            }
            if (line == "5")
            {
                int[] A = { 3, 1, 2, 4, 3 };
                var OddOccurencleArray = new TapeEquilibrium();
                Console.WriteLine(OddOccurencleArray.solution(A));
            }
            if (line == "6")
            {
                int[] A = { 3, 1, 2, 4, 3 };
                var OddOccurencleArray = new FrogJmp();
                Console.WriteLine(OddOccurencleArray.solution(10, 85, 30));
            }
            if (line == "7")
            {
                int[] A = { 4, 1, 3, 2 };
                var OddOccurencleArray = new PermCheck();
                Console.WriteLine(OddOccurencleArray.solution(A));
            }
            if (line == "8")
            {
                int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
                var OddOccurencleArray = new FrogRiverOne();
                Console.WriteLine(OddOccurencleArray.solution(3, A));
            }
            if (line == "9")
            {
                int[] A = { 1, 2, 3 };
                int[] B = { -1, -2, -3 };
                var OddOccurencleArray = new MissingInteger();
                Console.WriteLine(OddOccurencleArray.solution(A));
                Console.WriteLine(OddOccurencleArray.solution(B));
            }
            if (line == "10")
            {
                int[] A = { 3, 4, 4, 6, 1, 4, 4 };
                var maxCounters = new MaxCounters();
                Console.WriteLine(maxCounters.solution(5,A));

            }
        }
    }
}
