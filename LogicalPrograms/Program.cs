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
            Console.WriteLine("Enter a number to check if it is perfect:");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid input. Number must be a positive integer.");
                return;
            }

            PerfectNumber perfectNumber = new PerfectNumber(number);
            perfectNumber.CheckPerfectNumber();
        }
    }
}
