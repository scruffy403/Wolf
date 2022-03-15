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
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
                      

            Book book2 = new Book("Lord of the Rings", "Tolkien", 700);
            

            Console.WriteLine("Here are the details about book 1. Title: " + book1.title + ". The author is: " + book1.author +". and it is " + book1.pages + " pages long.");
            Console.WriteLine("Here are the details about book 1. Title: " + book2.title + ". The author is: " + book2.author + ". and it is " + book2.pages + "  pages long.");

            Console.ReadLine();
        }     
      
    }
}
