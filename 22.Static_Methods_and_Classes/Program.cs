using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Methods_and_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static method is about the class itself no need to create objects to get the class
            UsefullTools.SayHi("Arthur");
            Console.ReadLine(); 
        }
    }
}
