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

            // \n to create a newline "Wolf\nAcademy"
            // \" to keep a quotation within a string: "Wolf \" Academy" -> Wolf " Academy

            string phrase = "Wolf Academy"; // phrase.Length will give the length of the string
           

            Console.WriteLine( phrase.Substring(5, 3) );

            Console.ReadLine();
        }
    }
}
