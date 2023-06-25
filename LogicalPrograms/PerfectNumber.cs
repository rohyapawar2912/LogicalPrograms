using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        private int number;

        public PerfectNumber(int number)
        {
            this.number = number;
        }

        public void CheckPerfectNumber()
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number.");
            }
        }

    }
}
