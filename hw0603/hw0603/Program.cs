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
            Book b = new Book("title", "content", "author", "category");
            Console.WriteLine(b);
        }
    }
}
