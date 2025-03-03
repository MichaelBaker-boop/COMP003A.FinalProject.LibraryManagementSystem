using System.Linq;

namespace COMP003A.FinalProject.LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> ownedBooks = new List<Book>();
            List<Book> unavailableBooks = new List<Book>();
            int menuSelection = 0;
            Console.WriteLine("Weclome to the library management system!");

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

                        Console.WriteLine($"{newBook.Title}, {newBook.Author}, {newBook.ISBN}");
                        ownedBooks.Add(newBook);
                        Console.WriteLine("Book added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("You are currently removing a book from the system");
                        validInput = false;
                        while (!validInput)
                        {
                            Console.WriteLine("Enter title of book to be removed");
                            string bookTitle = Console.ReadLine();
                            if (string.IsNullOrEmpty(bookTitle))
                            {
                                Console.WriteLine("Title cannot be empty. Please try again");
                            }
                            else
                            {

                                bool removal = ownedBooks.Contains(bookTitle);
                                
                            }

                        }
                        break;
                    case 3:
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
