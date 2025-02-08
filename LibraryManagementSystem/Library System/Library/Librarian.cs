using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : User
    {
        public int EmployeeNumber { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newbook, Library library)
        {
            library.Add(newbook);
        }

        public void RemoveBook(Book book, Library library)
        {
            library.Remove(book);
        }
    }
}
