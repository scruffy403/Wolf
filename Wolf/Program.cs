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
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {4, 5},
            };

            Console.WriteLine(numberGrid[1,0]);
            
            Console.ReadLine();
        }     
      
    }
}
