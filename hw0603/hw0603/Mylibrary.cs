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

        public Book GetBookByAuthor(string anybook)
        {
            Dictionary<string, Book> booksbyauthor = books;
            if (booksbyauthor.TryGetValue(anybook, out Book result))
            {
                return result;
            }
            return null;
        }

        public void Clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            
        }

        public List<Book> GetBooksSOrtedByAuthorName()
        {

        }

        public List<string> GetBooksTitleSorted()
        {
        }

        public int Count { get { return books.Count; } }

        public override string ToString()
        {
            string result = null;
            if(books.Count != null)
            {
                result = base.ToString();
                foreach(var book in books)
                {
                    return result;
                }
            }
            else
            {
                return $"Library is empty!";
            }
            return result;
        }
    }
}
