using System;
using System.Collections.Generic;
using System.Text;

namespace C__Programs
{
    internal class ExecutionTime
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1000000; i++)
            {
                double time = Math.Sqrt(i);
            }

            DateTime end = DateTime.Now;

            TimeSpan executionTime = start - end;
            Console.WriteLine("Execution Time: "+executionTime.TotalMilliseconds);
        }

    }
}
