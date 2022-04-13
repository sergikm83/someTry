using System;

namespace TestExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int result=Solution.GetResult(new int[] { 15,0,4,95,8,54,1558,327,7,26,96 });
            Console.WriteLine(result);
        }
    }
    static class Solution
    {
        public static int GetResult(int[] A)
        {
            int count = 0;
            const int maxValue = 10000;
            if (A!=null)
            {
                for (int i=0;i<A.Length;i++)
                {
                    for (int j=i+1;j<A.Length;j++)
                    {
                        if (i + A[i] >= j - A[j])
                            count++;
                    }
                }
            }
            return count < maxValue ? count : -1;
        }
    }
}
