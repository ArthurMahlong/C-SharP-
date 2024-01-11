using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling methods with a return type
            Console.WriteLine(cube(5));

            //this wont give anything to console
            cube(5);

            Console.ReadLine(); 
        }
        //declare a method with a return type
        static int cube(int n) 
        {
            int result = n * n * n;

            return result;
        }
    }
}
