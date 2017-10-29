namespace CodeilityCSharp
{
    public class Dominator

    {
        public int solution(int[] A)
        {
            if (A.Length == 0)
                return -1;
            int count = 0;
            int elem = A[0];

            foreach (var i in A)
            {
                if (i == elem)
                {
                    count++;
                }
                else
                {
                    if (count == 0)
                    {
                        count++;
                        elem = i;
                    }
                    else count--;
                }
            }

            int ct = 0;
            int ind = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == elem)
                {
                    ct++;
                    ind = i;
                }

            }

            if (ct > A.Length / 2)
                return ind;
            else
                return -1;
        }
    }
}