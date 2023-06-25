using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Press 's' to start the stopwatch:");
            if (Console.ReadKey().KeyChar == 's')
            {
                Console.WriteLine();
                stopwatch.Start();
            }

            Console.WriteLine("Press 'e' to stop the stopwatch:");
            if (Console.ReadKey().KeyChar == 'e')
            {
                Console.WriteLine();
                stopwatch.Stop();
            }

           // TimeSpan elapsedTime = stopwatch.();
           // Console.WriteLine("Elapsed time: " + elapsedTime.TotalSeconds + " seconds");
        }
    }
}
