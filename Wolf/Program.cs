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

            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // to handle decimal numbers set variables to double and use Convert.ToDouble instead

            Console.WriteLine(number1 + number2);

            Console.ReadLine();
        }
    }
}
