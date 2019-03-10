using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0603
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylibrary library = new Mylibrary();

            Book a = new Book("harry potter", "sci-fi", "JK Rowling", "magic");
            Book b = new Book("war and peace", "i have no content", "dolsto", "");

            library.AddBook(a);
            library.AddBook(b);

            Console.WriteLine(library);
        }
    }
}
