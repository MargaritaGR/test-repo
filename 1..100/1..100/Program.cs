using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._._100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            while (b)
            {
                Console.Write("Enter a number in the range [1..100]:");
                var n = int.Parse(Console.ReadLine());
                if ((n >= 1) && (n <= 100))
                {
                    Console.WriteLine("The number is: " + n);
                    b = false;
                }
                else
                    Console.WriteLine("Invalid number! Try again!");
                
                
            }


        }
    }
}
