using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test that is either true or false
            bool isMale = true;
            if (isMale) 
            {
                Console.WriteLine("You are a Male");

            }
            else
            {
                Console.WriteLine("You are a Female");

            }
            //testing two conditions
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and Tall");
                Console.WriteLine(isTall);
            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("You are Short and a male");
                Console.WriteLine(isTall);
            }
            
            else
            {
                Console.WriteLine("You are either not tall or a male");
            }

            Console.ReadLine(); 

            
        }
    }
}
