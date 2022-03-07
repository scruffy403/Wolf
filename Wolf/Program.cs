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

            Console.WriteLine(GetPower(4, 3));
            Console.ReadLine();
        }
        
        static int GetPower(int baseNumber, int powerNumber)
        {
            int result = 1;

            for (int i = 0; i < powerNumber; i++)
            {
                result = result * baseNumber;
            }

            return result;
        }
    }
}
