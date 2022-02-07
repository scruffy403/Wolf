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

            // most common data types
            string phrase = "Wolf academy";
            char grade = 'B'; // for single character only
            int age = 30;
            // for decimal numbers options, from least to most precise are: float, double, decimal
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine("There is a student at " + phrase + ". Their age is " + age + ", their grade is " + grade + ", and their GPA is " + gpa + ".");

            Console.ReadLine();
        }
    }
}
