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
            Console.WriteLine(GetMax(10, 4, 3));
                        
            Console.ReadLine();
        }

        static int GetMax(int number1, int number2, int number3)
        {
            int result;

            if(number1 > number2 && number1 > number3)
            {
                result = number1;
            } else if (number1 < number2 && number2 > number3)
            {
                result = number2;
            } else
            {
                result = number3;
            }

            return result;
        }
        
    }
}
