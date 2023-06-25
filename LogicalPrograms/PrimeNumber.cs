using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        private int number;

        public PrimeNumber(int number)
        {
            this.number = number;
        }

        public void CheckPrimeNumber()
        {
            if (number <= 1)
            {
                Console.WriteLine(number + " is not a prime number.");
                return;
            }

            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}
