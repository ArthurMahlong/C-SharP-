using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number :");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number / number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
            Console.Read();
        }
    }
}
