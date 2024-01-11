using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Building_a_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To convert a sting to a numeric value
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( num1 + num2);

            //converting double 
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);
            Console.ReadLine(); 
        }
    }
}
