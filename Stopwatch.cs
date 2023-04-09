using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Stopwatch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the stopwatch.");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Stopwatch started at {0:hh:mm:ss.fff tt}", startTime);

            Console.WriteLine("Press any key to stop the stopwatch.");
            Console.ReadKey();

            DateTime endTime = DateTime.Now;

            Console.WriteLine("Stopwatch stopped at {0:hh:mm:ss.fff tt}", endTime);

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine("Elapsed time: {0:%h} hours, {0:%m} minutes, {0:%s} seconds, {0:%fff} milliseconds", elapsedTime);
        }
    }
}
