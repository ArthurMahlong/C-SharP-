using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song Holiday = new Song("Holiday", "Green Day", 5);
            Song kashmir = new Song("Kashmir", "Zeppelin", 4);

            Console.WriteLine(Song.songCount);
            Console.Read();
        }
    }
}
