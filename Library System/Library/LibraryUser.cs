using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser : User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard Card { get; set; }


        public void BorrowBooks(Book book, Library library)
        {
            library.BorrowBook(book);
        }
    }
}
