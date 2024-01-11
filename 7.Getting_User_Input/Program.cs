using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write to prompt user to enter details in will be on the same
            Console.Write("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            //Values inputed by the user are always in a string format
            string age = Console.ReadLine();
            Console.WriteLine("you are " + age + " years");

            Console.ReadLine();

        }
    }
}
