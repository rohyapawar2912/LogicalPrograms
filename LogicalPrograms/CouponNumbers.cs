using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        private int[] couponNumbers;
        private Random random;

        public CouponNumbers(int[] couponNumbers)
        {
            this.couponNumbers = couponNumbers;
            this.random = new Random();
        }

        public int GenerateDistinctCoupons()
        {
            HashSet<int> distinctCoupons = new HashSet<int>();
            int attempts = 0;

            while (distinctCoupons.Count < couponNumbers.Length)
            {
                int randomCoupon = GenerateRandomCoupon();
                distinctCoupons.Add(randomCoupon);
                attempts++;
            }

            return attempts;
        }

        private int GenerateRandomCoupon()
        {
            int index = random.Next(0, couponNumbers.Length);
            return couponNumbers[index];
        }
    }
}
