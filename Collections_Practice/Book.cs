using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        // Parameterized Constructor
        public Book(string title, string author)
        {
            //Title = title;
            //Author = author;
            Console.WriteLine($"Book { Title} created with { Author}");
        }

        // Overloaded Constructor calling the parameterized constructor
        //public Book(string title) : this(title, "Unknown Author")
        public Book(string title)
        {
            this.Title = title;

            Console.WriteLine($"Book {Title} created with unknown author.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating objects with different constructors
            Book book1 = new Book("C# Programming", "John Smith");
            //Book book2 = new Book("Learning C#");
        }
    }
}
