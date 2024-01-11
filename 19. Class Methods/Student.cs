using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aweight, string aname, int aAge)
        {
            this.weight = aweight;
            this.name = aname;
            this.age = aAge;
        }
        public bool isObesse()
        {
            if (weight > 60)
            {
                return true;
            }
            else return false;

        }
    }
}
