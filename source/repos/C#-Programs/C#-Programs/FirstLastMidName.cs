using System;
using System.Collections.Generic;
using System.Text;

namespace C__Programs
{
    internal class FirstLastMidName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Full name");
            String FullName = Console.ReadLine();
           String[] parts = FullName.Split(' ');
            int len = parts.Length;
            Console.WriteLine("Number of parts in the name: "+len);
           
            foreach (String part in parts)
            {
                Console.Write(part+" ");
            }
        }
    }
}
