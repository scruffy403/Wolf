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
            SayHi("Fresh", 30);
            SayHi("Jeremy", 65);
            SayHi("Simba", 42);
            Console.ReadLine();
        }

        static void SayHi( string name, int age )
        {
            Console.WriteLine("Hello, " + name + "!" + " You are " + age + ".");
        }
    }
}
