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
                }
            }
        }
    }
}
