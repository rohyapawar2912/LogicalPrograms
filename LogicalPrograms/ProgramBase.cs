using System;

namespace LogicalPrograms
{
    public class ProgramBase
    {

        private static int[] GenerateDistinctCoupons(int n)
        {
            int[] coupons = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                coupons[i] = random.Next(1, 1000); // Adjust the range as per your requirement
            }
        }
    }
}