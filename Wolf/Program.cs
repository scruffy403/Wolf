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
            bool isMale = false;
            bool isTall = false;
            
            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male.");
            } else if(isMale && !isTall)
            {
                Console.WriteLine("You are not a tall male");
            } else if(!isMale && isTall)
            {
                System.Console.WriteLine("You are not a male. You are tall.");
            } else
            {
                Console.WriteLine("You are not male. You are not tall.");
            }
            
            Console.ReadLine();
        }
        
    }
}
