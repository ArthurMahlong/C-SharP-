using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef:Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian chef makes ItalianSpecials"); 
        }
    }
}
