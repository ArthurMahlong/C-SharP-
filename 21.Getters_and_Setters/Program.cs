using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    class Movie
    {
        public string title;
        public string director;
        public string rating; // getters and setters

        public Movie(string atitle, string adirector, string arating)
        {
            title = atitle; 
            director = adirector;
            rating = arating;
        }
        public string Rating
        {
            get { return rating; }

            set 
                {
                if (value == "G" || value == "PG" || value == "PG-13" ||value == "v")
                {
                    rating = value;
                }
                else rating = "NR";
                }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie film = new Movie("Titanic", "Jim", "PG-13");
            Movie film1 = new Movie("Unreleased","Evans","PG");

            Console.WriteLine(film1.rating);
            Console.WriteLine(film.rating);

            Console.Read();
        }
    }
}
