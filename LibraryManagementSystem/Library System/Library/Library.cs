using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library
{
    public class Library
    {
        private int currentBookCount = 0;
        private int currentBorrowedBookCount = 0;
        private Book[] books = new Book[100];

        private Book[] borrowedBooks = new Book[50];

        public void Display()
        {
            for (int i = 0; i < currentBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }

        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("Book Added Successfully");
            }
            else
            {
                Console.WriteLine("Library is Full can't add new books");
            }

        }

        public void Remove(Book book)
        {
            int index = -1;
            for (int i = 0; i < currentBookCount; i++)
            {
                if (books[i].Title == book.Title &&
                    books[i].Author == book.Author &&
                    books[i].Year == book.Year)
                {
                    index = i;
                    break;
                }

            }
            if (index != -1)
            {
                for (int i = index; i < currentBookCount - 1; i++)
                {
                    books[i] = books[i + 1];
                }
                books[currentBookCount - 1] = null;
                currentBookCount--;
                Console.WriteLine("Book Removed Successfully");
            }
            else
                Console.WriteLine("Doesn't Exist");
        }

        public void BorrowBook(Book book)
        {
            if (currentBorrowedBookCount < borrowedBooks.Length)
            {
                borrowedBooks[currentBorrowedBookCount] = book;
                currentBorrowedBookCount++;
                Console.WriteLine("Book Added Successfully");
            }
            else
            {
                Console.WriteLine("Can't Borrow More Books");
            }
        }
    }
}