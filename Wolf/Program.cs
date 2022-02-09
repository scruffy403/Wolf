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
            int[] luckyNumbers = { 1, 2, 3, 4, 5, };
            int[] luckyNumbers2 = { 4, 8, 15, 16, 23, 42 };

            luckyNumbers[1] = 900;

            string[] friends = new string[10]; // if you don't populate the array when you create it you need to specify how many elements it can hold
            friends[0] = "Donny";
            friends[1] = "Sip";

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers2[2]);

            Console.ReadLine();
        }
    }
}
