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
            Console.WriteLine("Enter a number to reverse:");
            int number = int.Parse(Console.ReadLine());

            ReverseNumber reverseNumber = new ReverseNumber(number);
            int reversedNumber = reverseNumber.Reverse();

            Console.WriteLine("Reversed number: " + reversedNumber);
        }
    }
}
