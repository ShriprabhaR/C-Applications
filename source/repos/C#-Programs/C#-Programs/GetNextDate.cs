using System;
using System.Collections.Generic;
using System.Text;

namespace C__Programs
{
    internal class GetNextDate
    {static void Main(string[] args)
        {
            Console.Write("Input a Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Input a Month[1-12]: ");
            int month = int.Parse(Console.ReadLine());
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Enter valid month");
            }

            Console.Write("Input a date[1-31]: ");
            int date = int.Parse(Console.ReadLine());

            if (date < 1 || date > 31)
            {
                Console.WriteLine("Enter valid date");
            }



            if (month == 12 && date == 31)
            {
                month = 1;
                date = 1;
                year++;
            }
           else if (date < 31 && month == 12)
            {
                date++;

            }
            else if(date == 31 && month < 12)
            {
                date = 1;
                month++;
            }

            if (month == 2 && date > 29)
            {
                    Console.WriteLine("Invalid date");
            }

            Console.WriteLine(year + "-" + month + "-" + date);

            Console.ReadLine();
        }

            

    }
}
