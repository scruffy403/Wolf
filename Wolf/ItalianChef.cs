using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolf
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parmesan.");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes pasta.");
        }
    }
}
