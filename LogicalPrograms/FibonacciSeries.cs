using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        private int count;

        public FibonacciSeries(int count)
        {
            this.count = count;
        }

        public void GenerateSeries()
        {
            int first = 0;
            int second = 1;
            Console.WriteLine("Fibonacci series:");
            Console.Write(first + " " + second + " ");

            for (int i = 2; i < count; i++)
            {
                int next = first + second;
                Console.Write(next + " ");

                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}
