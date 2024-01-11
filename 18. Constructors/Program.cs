using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK Row;ing", 400);
            Console.WriteLine(book1.title);
            Console.Read();
        }
        class Book
        {
            public string title;
            public string author;
            public int pages;

            public Book(string aTitle, string aAuthor, int aPages)
            {
                title = aTitle;
                author = aAuthor;
                pages = aPages;
            }
        }

    }
}
