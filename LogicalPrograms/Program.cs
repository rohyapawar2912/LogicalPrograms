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
            Console.WriteLine("Enter a number to check if it is prime:");
            int number = int.Parse(Console.ReadLine());

            PrimeNumber primeNumber = new PrimeNumber(number);
            primeNumber.CheckPrimeNumber();
        }
    }
}
