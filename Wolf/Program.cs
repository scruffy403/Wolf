// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Wolf
{
    class Program
    {
        static void Main(string[] args)
        {
            // math operations with int's will return int: 5 / 4 would return 1
            // to access the more accurate decimal answer convert one to decimal: 5 / 4.0 returns 1.25
            // Math. to access math methods for more complex operations

            int number = 6;
            number--;

            Console.WriteLine(Math.Pow(9, 2));

            Console.ReadLine();
        }
    }
}
