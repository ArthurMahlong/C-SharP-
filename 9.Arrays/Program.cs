using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneWayAttribute way of creating an array
            int[] luckyNumbers = { 4, 5, 8, 9, 10 };
            Console.WriteLine(luckyNumbers[0]);

            //If you want to populate it later, 5 is the size
            string[] friends = new string[5];
            friends[0] = "Arthur";
            friends[1] = "Barthur";
            friends[2] = "Carthur";
            Console.WriteLine(friends[0]);

            Console.ReadLine(); 
        }
    }
}
