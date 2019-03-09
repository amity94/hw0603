using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw0603
{
    class Book
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
            this.Category = category;
        }

        public override string ToString()
        {
            return $"Book Title: {Title}, Content: {Content}, Author: {Author}, Category: {Category}";
        }

    }
}
