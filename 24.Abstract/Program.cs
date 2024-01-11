using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car = new Vehicle();
            Corsa car2  = new Corsa();

            Console.WriteLine("This type of vehicle has "+car2.wheels+ " wheels");
            Console.WriteLine("It has  "+car2.spareWheels+ " spare(s) wheel(s)");

            Console.ReadLine();
        }
    }

    abstract class Vehicle
    {
        public int wheels = 4;

    }
    class Corsa:Vehicle 
    {
        public int spareWheels = 1;
    }
    
}
