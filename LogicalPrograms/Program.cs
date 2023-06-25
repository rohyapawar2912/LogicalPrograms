using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of distinct coupon numbers:");
            int n = int.Parse(Console.ReadLine());

            int[] couponNumbers = GenerateDistinctCoupons(n);
            CouponNumbers coupon = new CouponNumbers(couponNumbers);
            int attempts = coupon.GenerateDistinctCoupons();

            Console.WriteLine("Total random numbers needed to have all distinct numbers: " + attempts);
        }

        private static int[] GenerateDistinctCoupons(int n)
        {
            int[] coupons = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                coupons[i] = random.Next(1, 1000); // Adjust the range as per your requirement
            }

            return coupons;
        }
    }
}
