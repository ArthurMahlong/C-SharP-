using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What is your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age : ");
            int age = int.Parse(Console.ReadLine());
            //calling methodds and functions in c#
            SayHi();

            //Method with parameters
            SayHiUser(name);

            //method with more than one parameters
            SayHiAge(name, age);

            Console.ReadLine();

        }

        static void SayHi()
        {
            Console.WriteLine("Hi ");

        }
        static void SayHiUser(string name) 
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHiAge(string name, int age)
        {
            Console.WriteLine("Hello "+ name + " you are  "+  age + " years old");
        }
    }
}
