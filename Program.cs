using System;
using CodeilityCSharp;
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
                Console.WriteLine(maxCounters.solution(5, A));

            }

            if (line == "13")
            {
                int[] A = { 0, 1, 0, 1, 1 };
                var maxCounters = new PassingCars();
                Console.WriteLine(maxCounters.solution(A));

            }
            if (line == "14")
            {
                int[] A = { 4, 2, 2, 5, 1, 5, 8 };
                var minAvgTwoSlice = new MinAvgTwoSlice();
                Console.WriteLine(minAvgTwoSlice.solution(A));

            }
            if (line == "15")
            {
                int[] A = { 2, 5, 0 };
                int[] B = { 4, 5, 6 };
                var genomicRangeQuery = new GenomicRangeQuery();
                Console.WriteLine(genomicRangeQuery.solution("CAGCCTA", A, B));

            }
            if (line == "15")
            {
                int[] A = { 1, 2, 3 };

                var distinct = new Distinct();
                Console.WriteLine(distinct.solution(A));

            }
            if (line == "16")
            {
                int[] A = { 1, 5, 2, 1, 4, 0 };

                var numberOfDiscIntersections = new NumberOfDiscIntersections();
                Console.WriteLine(numberOfDiscIntersections.solution(A));

            }

            if (line == "18")
            {
                var A = "{[()()]}";

                var brackets = new Brackets();
                Console.WriteLine(brackets.solution(A));

            }
            if (line == "19")
            {
                int[] A = { 4, 3, 2, 1, 5 };
                int[] B = { 0, 1, 0, 0, 0, 0 };
                var fish = new Fish();
                Console.WriteLine(fish.solution(A, B));

            }
            if (line == "20")
            {
                int[] A = { 3, 4, 3, 2, 3, -1, 3, 3 };

                var dominator = new Dominator();
                Console.WriteLine(dominator.solution(A));

            }
            if (line == "21")
            {
                var S = "test 5 a0A pass007 ?xy1";

                var longestPassword = new LongestPassword();
                Console.WriteLine(longestPassword.solution(S));

            }
            if (line == "22")
            {
                int[] A = { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 };

                var floodDepth = new FloodDepth();
                Console.WriteLine(floodDepth.solution(A));

            }
            if (line == "23")
            {
                int[] A = { 15, 13, 5, 7, 4, 10, 12, 8, 2, 11, 6, 9, 3 };

                var slalomSkiing = new SlalomSkiings();
                Console.WriteLine(slalomSkiing.solution(A));

            }
        }
    }
}
