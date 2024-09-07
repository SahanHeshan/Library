using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books;
        private int bookCount;

        public Library(int Size) { 
            books = new Book[Size];
            bookCount = 0;
        }

        public void addBook(Book book) {
            books[bookCount] = new Book(book.title, book.author, book.isbn);
            bookCount++;
            Console.WriteLine($"Book {book.title} added to the library.");

        }

        public void seeBooks() {
            Console.WriteLine("\n");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.title} {book.author} {book.isbn} {book.isBorrowed} \n");
            }
        }

        public void borrowBook (String title)
        {
            foreach (Book book in books)
            {
                if (book.title == title)
                {
                    book.borrow();
                    break;
                }
            }


        }
    }
}
