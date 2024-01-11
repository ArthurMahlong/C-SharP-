using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.The_FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The while loop for reference");
            int i = 0;

            while (i <= 5) 
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("The for loop");
            for(i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
