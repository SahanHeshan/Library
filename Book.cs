using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public string title;
        public string author;
        public string isbn;
        public bool isBorrowed;

        public Book(string title, string author, string isbn )
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            isBorrowed = false;
        }

        public void borrow() { 
            if (isBorrowed) 
                Console.WriteLine("Sorry! Book Not Available");
            else
                Console.WriteLine("You Got the Book");
                isBorrowed=true;
        }

    }
}
