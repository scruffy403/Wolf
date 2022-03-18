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
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(holiday.getSongCount()); // use this to access the static attribute from the object
            Console.WriteLine(kashmir.artist);

            Console.ReadLine();
        }     
      
    }
}
