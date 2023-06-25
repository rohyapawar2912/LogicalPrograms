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
            Console.WriteLine("Enter the count of terms in the Fibonacci series:");
            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("Invalid input. Count must be a positive integer.");
                return;
            }

            FibonacciSeries fibonacciSeries = new FibonacciSeries(count);
            fibonacciSeries.GenerateSeries();
        }
    }
}
