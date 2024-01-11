using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_With_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \"  print out the qoutation mark.");

            string firstName = "Arthur";
            string LastName = "Mahlong";

            //concatination
            Console.WriteLine(firstName + " " + LastName);

            //functions with strings
            Console.WriteLine(LastName.Length);

            //methods on string
            Console.WriteLine(firstName.ToUpper());

            //method with  parameter eg the contains(), its case sensitive
            Console.WriteLine(LastName.Contains("lon"));

            //access characters using index
            Console.WriteLine(firstName[0]);

            //Indexof will tell you if the value is there and at what position
            Console.Write("Index of a is ");
            Console.WriteLine(LastName.IndexOf("a"));
              
            //substring, to grab from an index onwards
            Console.WriteLine(firstName.Substring(1));

            //you can also give index and length ie how many chars you want to grab
            Console.WriteLine(firstName.Substring(0,3));
            Console.Read();




        }
    }
}
