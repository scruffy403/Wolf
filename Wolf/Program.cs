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
            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter anohter number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }     
      
    }
}
