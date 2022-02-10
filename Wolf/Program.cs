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
            int number;
            Console.Write("Enter a number between 1 and 7: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(number));
            
            Console.ReadLine();
        }

        static string GetDay(int dayNumber)
        {
            string dayName;

            switch (dayNumber)
            {
                case 1: 
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number!";
                    break;
            }

            return dayName;
        }

              
    }
}
