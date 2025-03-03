namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public class ListMove<Book> : IListMover<Book>
    {
        // Method to be implemented to move book between owned and rented
        public void Move(Book newBook, List<Book> ownedBooks, List<Book> unavailableBooks)
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
