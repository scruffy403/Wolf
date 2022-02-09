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
           
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("What is your age? ");
            string age = Console.ReadLine();
            Console.Write("What city were you born in? ");
            string whereBorn = Console.ReadLine();

            Console.Write("Hello, " + name + "! You are " + age + " years old. " + whereBorn + " is a nice city!");


            Console.ReadLine();
        }
    }
}
