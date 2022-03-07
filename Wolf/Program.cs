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
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i <  luckyNumbers.Length; i++)
            {
                Console.Write("The number is: ");
                Console.WriteLine(luckyNumbers[i]);
            }

            for (int j = 10; j <= 40; j+=5) 

            {
                Console.Write("These numbers skip by 5, see: ");
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }              
    }
}
