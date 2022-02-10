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
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            if(op == "+") 
            {
                Console.Write(number1 + number2);
            } else if (op == "-")
            {
                Console.Write(number1 - number2);
            } else if (op == "*" || op == "x" || op == "X")
            {
                Console.Write(number1 * number2);
            } else if(op == "/")
            {
                Console.Write(number1 / number2);
            } else
            {
                Console.Write("You have entered an invalid characer. Try again :)");
            }

            Console.ReadLine();
        }

              
    }
}
