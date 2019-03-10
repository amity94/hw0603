using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0603
{
    class Mylibrary
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public Mylibrary()
        {

        }

        public bool AddBook(Book anybook)
        {
            if (!books.ContainsKey(anybook.Title))
            {
                books.Add(anybook.Title, anybook);
                return true;
            }
            return false;
        }

        public bool RemoveBook(string anybook)
        {
            if (books.ContainsKey(anybook))
            {
                books.Remove(anybook);
                return true;
            }
            else
            {
                Console.WriteLine("The Book Doesn't Exist");
                return false;
            }
        }

        public bool HaveThisBook(string anybook)
        {
            if (books.ContainsKey(anybook))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book GetBook(string anybook)
        {
            if (books.TryGetValue(anybook, out Book result))
            {
                return result;
            }
            return null;
        }

        public Book GetBookByAuthor(string author)
        {
            foreach(var book in books.Values)
            {
                if(book.Author == author)
                {
                    return book;
                }
            }
            return null;
        }

        public void Clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach(var book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> _books = new List<Book>();
            foreach (var book in books.Values)
            {
                _books.Add(book);
            }
            _books.Sort();
            return _books;
        }

        public List<string> GetBooksTitleSorted()
        {
            List<string> titles = new List<string>();
            foreach (var book in books.Values)
            {
                titles.Add(book.Title);
            }
            titles.Sort();
            return titles;
        }

        public int Count { get { return books.Count; } }

        public override string ToString()
        {
            string result = $"MyLibrary contains {Count} books. ";

            foreach (KeyValuePair<string, Book> pair in books)
            {
                result += $"{pair.Key} {pair.Value}. ";
            }
            return result;
            
        }
    }
}
