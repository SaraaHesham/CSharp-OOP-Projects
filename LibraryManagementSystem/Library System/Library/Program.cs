namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Library System ");

            Library library = new Library();

            Console.WriteLine("Are You A Librarian(l) Or A Regular User(r) : ");

            char UserType = Console.ReadLine().ToLower()[0];

            if (UserType == 'l')
            {
                // librarian logic
                Console.WriteLine("Welcome Librarian ,Please Enter Your Name :");
                string librarianname = Console.ReadLine();

                Librarian l1 = new Librarian(librarianname);

                Console.WriteLine($"Welcome {l1.Name}");

                while (true)
                {
                    Console.WriteLine("Choose (a) To Add / (r) To Remove / (d) To Display / (e) To Exit");

                    char librarianchoice = Console.ReadLine().ToLower()[0];

                    switch (librarianchoice)
                    {
                        case 'a':
                            // add
                            Console.WriteLine("Enter Book Details To Add ");
                            string bookname = Console.ReadLine();
                            string authorname = Console.ReadLine();
                            int year = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookname,
                                Author = authorname,
                                Year = year
                            };
                            l1.AddBook(book, library);
                            break;
                        case 'r':
                            // remove
                            Console.WriteLine("Enter Book Details To Remove ");
                            bookname = Console.ReadLine();
                            authorname = Console.ReadLine();
                            year = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookname,
                                Author = authorname,
                                Year = year
                            };
                            l1.RemoveBook(book, library);
                            break;
                        case 'd':
                            // display
                            Console.WriteLine("The List Of Books In The Library :");
                            l1.DisplayBooks(library);
                            break;
                        case 'e':
                            // exit
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Only Enter (a-r-d-e)");
                            break;

                    }
                }
            }
            else if (UserType == 'r')
            {
                // regular user logic
                Console.WriteLine("Welcome User ,Please Enter Your Name :");
                string username = Console.ReadLine();

                LibraryUser u1 = new LibraryUser(username);

                Console.WriteLine($"Welcome {u1.Name}");

                while (true)
                {
                    Console.WriteLine("Choose (b) To Borrow / (d) To Display / (e) To Exit");

                    char librarianchoice = Console.ReadLine().ToLower()[0];

                    switch (librarianchoice)
                    {
                        case 'b':
                            // borrow
                            Console.WriteLine("Enter Book Details To Add ");
                            string bookname = Console.ReadLine();
                            string authorname = Console.ReadLine();
                            int year = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookname,
                                Author = authorname,
                                Year = year
                            };
                            u1.BorrowBooks(book, library);
                            break;
                        case 'd':
                            // display
                            Console.WriteLine("The List Of Books In The Library :");
                            u1.DisplayBooks(library);
                            break;
                        case 'e':
                            // exit
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Only Enter (b-d-e)");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Please Enter Only ( l Or r )");
            }
        }
    }
}
