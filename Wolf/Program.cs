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
            int index = 6;
            // do/while loop, do portion gets executed before the while condition is checked
            do
            {
                Console.WriteLine("The number is: " + index);
                index++;
            } while (index <= 5);



            Console.ReadLine();
        }              
    }
}
