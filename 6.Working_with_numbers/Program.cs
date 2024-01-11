using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //you can just print out numbers
            Console.WriteLine(5);

            //operators can be used ie + - * /
            Console.WriteLine(6 + 5);

            //Modulos operator to get reminder
            Console.WriteLine(5%2);
            //BODMAS still Applies
            Console.WriteLine(4+2*3);
            //Integer variables always returns an intefer value
            Console.WriteLine(5/2);
            //Double and integ+er returns a double
            Console.WriteLine(5/2.0);
            //can give a number to a variable
            int num = 6;
            //can increment or decrement by 1
            num++;
            Console.WriteLine(num);
            //calling math methods abs = to return positive value
            Console.WriteLine(Math.Abs(-100));
            //to raise to the power
            Console.WriteLine(Math.Pow(2,2));

            Console.ReadLine(); 
        }
    }
}
