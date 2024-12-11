using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace C__Programs
{
    internal class SquareOfSumAndDiff
    {
        static void Main(string[] args)
        {
            double a, b;
            SquareOfSumAndDiff diff = new SquareOfSumAndDiff();
            Console.WriteLine(" Enter the value a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the value b");
            b = double.Parse(Console.ReadLine());
            diff.SquareOfSumDiff(a, b);

        }

        public void SquareOfSumDiff(double a, double b)
        {
            double sum = a + b;
            double sumsq = sum * sum;
            Console.WriteLine("The square of the sum of " + a + " and " + b + " is: " + sumsq);

            double diff = a - b;
            double diffsq = diff * diff;
            Console.WriteLine("The square of the diff of " + a + " and " + b + " is: " + diffsq);

        }
    }
}
