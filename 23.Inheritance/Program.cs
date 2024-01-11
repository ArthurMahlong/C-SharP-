using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef chef2 = new ItalianChef();  
            chef2.MakeChicken();
            chef2.MakePasta();
            chef2.MakeSpecialDish();

            Console.ReadLine(); 
        }
    }
}
