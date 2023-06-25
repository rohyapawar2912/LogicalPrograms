using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopwatchProgram
    {
        private DateTime startTime;
        private DateTime endTime;
        private bool isRunning;

        public void Start()
        {
            if (isRunning)
            {
                Console.WriteLine("Stopwatch is already running!");
                return;
            }

            startTime = DateTime.Now;
            isRunning = true;
            Console.WriteLine("Stopwatch started!");
        }

        public void Stop()
        {
            if (!isRunning)
            {
                Console.WriteLine("Stopwatch is not running!");
                return;
            }

            endTime = DateTime.Now;
            isRunning = false;
            Console.WriteLine("Stopwatch stopped!");
        }

        public TimeSpan GetElapsedTime()
        {
            if (isRunning)
            {
                Console.WriteLine("Stopwatch is still running!");
                return TimeSpan.Zero;
            }

            return endTime - startTime;
        }
    }
}
