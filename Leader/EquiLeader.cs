namespace CodeilityCSharp
{
    public class EquiLeader

    {
        public int solution(int[] A)
        {
            int len = A.Length;
            int equi_leaders = 0;

            // first, compute the leader
            int leader = A[0];
            int ctr = 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == leader) ctr++;
                else ctr--;
                if (ctr == 0)
                {
                    ctr = 1;
                    leader = A[i];
                }
            }

            // check if it's a leader?
            int total = 0;
            foreach (var i in A)
            {
                if (i == leader)
                    total++;
            }

            if (total <= (len / 2)) 
                return 0; // impossible

            int ldrCount = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader) 
                    ldrCount++;
                int leadersInRightPart = (total - ldrCount);
                if (ldrCount > (i + 1) / 2 && leadersInRightPart > (len - i - 1) / 2)
                {
                    equi_leaders++;
                }
            }

            return equi_leaders;
        }
    }
}