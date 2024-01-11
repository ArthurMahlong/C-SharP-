using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string name;
            int age;
            

            //initialize variables
            name = "Arthur";
            age = 29;
      
            Console.WriteLine("Hi " +name);
            Console.WriteLine("You are "+ age +" years of age.");
            Console.WriteLine("Next year you will be " + (age + 1));

            age = age + 10;
            Console.WriteLine("in 10 years time you will be " + age);

            //Delcare and Initializing 
            string lastName = "Mahlong";
            Console.WriteLine("Your lastname is " + lastName);
            Console.WriteLine("Your full name is " + name + " " + lastName);
            
            //Pause the console
            Console.ReadLine();
          
        }
    }
}
