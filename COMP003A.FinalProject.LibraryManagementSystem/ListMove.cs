namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public class ListMove<PrintedBook> : IListMover<PrintedBook>
    {
        // Method to be implemented to move book between owned and rented
        public void Move(PrintedBook newBook, List<PrintedBook> ownedBooks, List<PrintedBook> unavailableBooks)
        {
            // For when a book is getting loaned out
            if (ownedBooks.Contains(newBook))
            {
                ownedBooks.Remove(newBook);
                unavailableBooks.Add(newBook);
            }
            // For whe a return is being made
            if (unavailableBooks.Contains(newBook))
            {
                unavailableBooks.Remove(newBook);
                ownedBooks.Add(newBook);
            }
            // Default message if the book doesn't exist
            else
            {
                Console.WriteLine("Sorry, that book does not exist in our system.");
            }
        }
      



    }
}
