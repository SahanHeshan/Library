using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library myLib = new Library(3);

            Book book1 = new Book("potha1", "sahan", "1485");
            Book book2 = new Book("potha2", "sahan", "3325");
            Book book3 = new Book("potha3", "sahan", "7854");

            myLib.addBook(book1);
            myLib.addBook(book2);
            myLib.addBook(book3);

            myLib.seeBooks();

            myLib.borrowBook("potha2");

            myLib.seeBooks();



        }
    }
}
