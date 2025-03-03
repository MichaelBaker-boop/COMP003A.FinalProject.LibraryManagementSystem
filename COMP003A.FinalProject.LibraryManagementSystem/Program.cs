using System.Linq;

namespace COMP003A.FinalProject.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> ownedBooks = new List<Book>();
            List<Book> unavailableBooks = new List<Book>();
            IListMover<Book> listMover = new CheckoutOrReturn<Book>();
            int menuSelection = 0;

            Console.WriteLine("Weclome to the library management system!");
            
            // Loop to keep main menu open until Exit is chosen
            bool menu = true;
            while (menu == true)
            {
                Console.WriteLine("Please choose an option: \n");
                Console.WriteLine("1) Add a new book.");
                Console.WriteLine("2) Remove an old book");
                Console.WriteLine("3) Check out a book");
                Console.WriteLine("4) Return a book");
                Console.WriteLine("5) Display available books");
                Console.WriteLine("6) Display unavailable books");
                Console.WriteLine("7) Exit");

                try
                {
                    menuSelection = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input invalid, must be a number");
                    Console.WriteLine(e.Message);
                    continue;
                }

                switch (menuSelection)
                {
                    case 1:
                        Console.WriteLine("You are currently adding a book to the system.");
                        bool validInput = false; //Initialize test of user input
                        Book newBook = new PrintedBook("", "", ""); // Create a new printed book object
                        while (!validInput) // While loop to verify input
                        {
                            // Gets title of book to add to system
                            Console.Write("Enter the title of the book: ");
                            newBook.Title = Console.ReadLine();
                            if (string.IsNullOrEmpty(newBook.Title))
                            {
                                Console.WriteLine("The title cannot be empty. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }

                        while (!validInput)
                        {
                            // Adds author to book
                            Console.WriteLine("Enter the book author: ");
                            newBook.Author = Console.ReadLine();
                            if (string.IsNullOrEmpty(newBook.Author))
                            {
                                Console.WriteLine("The author cannot be empty, please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }

                        while (!validInput)
                        {
                            // Adds ISBN to book
                            Console.WriteLine("Enter the book ISBN: ");
                            newBook.ISBN = Console.ReadLine();
                            if (string.IsNullOrEmpty(newBook.ISBN))
                            {
                                Console.WriteLine("The ISBN cannot be empty");
                            }
                            else
                            {
                                break;
                            }
                        }
                        // Checking input was successfull
                        Console.WriteLine($"{newBook.Title}, {newBook.Author}, {newBook.ISBN}");
                        // Add newBook to list of ownedBooks
                        ownedBooks.Add(newBook);
                        Console.WriteLine("Book added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("You are currently removing a book from the system");
                        validInput = false;
                        Book bookTitle = new PrintedBook("", "", "");
                        while (!validInput)
                        {
                            Console.WriteLine("Enter title of book to be removed");
                            string title = Console.ReadLine();
                            if (string.IsNullOrEmpty(title))
                            {
                                Console.WriteLine("Title cannot be empty. Please try again");
                            }
                            else
                            {

                                // checks if title is in owned books
                                if (ownedBooks.Contains(bookTitle))
                                {
                                    Console.WriteLine("Sorry, that book does not exist");
                                }
                                else
                                {
                                    ownedBooks.Remove(bookTitle);
                                    Console.WriteLine("Book removed successfully");
                                }
                                break;
                            }

                        }
                        break;

                    case 3:
                        Console.WriteLine("You are currently checking out a book");
                        validInput = false;
                        Book rentTitle = new PrintedBook("", "", "");
                        while (!validInput)
                        {

                            Console.WriteLine("Enter the title of the book: ");
                            string title = Console.ReadLine();
                            if (string.IsNullOrEmpty(title))
                            {
                                Console.WriteLine("Title cannot be empty. Please try again.");
                            }
                            else
                            {

                                listMover.Move(rentTitle, ownedBooks, unavailableBooks);
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("You are currently returning a book");
                        validInput = false;
                        Book returning = new PrintedBook("", "", "");
                        while (!validInput) // While loop to verify input
                        {
                            Console.Write("Enter the title of the book: ");
                            returning.Title = Console.ReadLine();
                            if (string.IsNullOrEmpty(returning.Title))
                            {
                                Console.WriteLine("The title cannot be empty. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (!validInput)
                        {
                            Console.WriteLine("Enter the book author: ");
                            returning.Author = Console.ReadLine();
                            if (string.IsNullOrEmpty(returning.Author))
                            {
                                Console.WriteLine("The author cannot be empty, please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (!validInput)
                        {
                            Console.WriteLine("Enter the book ISBN: ");
                            returning.ISBN = Console.ReadLine();
                            if (string.IsNullOrEmpty(returning.ISBN))
                            {
                                Console.WriteLine("The ISBN cannot be empty");
                            }
                            else
                            {
                                listMover.Move(returning, unavailableBooks, ownedBooks);
                                break;
                            }
                        }
                        
                        break;
                    case 5:
                        Console.WriteLine("Now displaying all books currently available: ");
                        foreach (var books in ownedBooks)
                        {
                            Console.WriteLine($"{books.Title}, {books.Author}, {books.ISBN}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Now displaying all books currently unavailable: ");
                        foreach (var books in unavailableBooks)
                        {
                            Console.WriteLine($"{books.Title}, {books.Author}, {books.ISBN}");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Have a good day!");
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Sorry, the selection must be one of the available choices. Please try again.");
                        break;
    
                }
            }
            
        }
    }
}
