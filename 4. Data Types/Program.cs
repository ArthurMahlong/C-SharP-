using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Arthur";
            int age = 29;
            bool isTall = false ;
            double weight = 25.5;
            
            //float height = 78.9;
            Console.WriteLine("Hi " +  name + ", you are " + age + " years old. And your weight is  " + weight);
            Console.WriteLine("true or false are you tall :" + isTall);

            Console.Read();


        }
    }
}
