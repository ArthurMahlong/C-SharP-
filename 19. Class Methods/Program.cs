using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim",10);

            Console.WriteLine("Is student name "+student1.name+ " Obesse " +student1.isObesse());
            Console.WriteLine("Is the student named " + student2.name + " obesse? T/F " + student2.isObesse());

            Console.ReadLine();
        }
    }
}
