namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public abstract class CheckoutOrReturn<Book> : IListMove<Book>
    {
        public void MoveItem(Book books, List<Book> ownedBooks, List<Book> unavailableBooks)
        {
            if (ownedBooks.Contains(books))
            {
                ownedBooks.Remove(books);
                unavailableBooks.Add(books);
            }
            if (unavailableBooks.Contains(books))
            {
                unavailableBooks.Remove(books);
                ownedBooks.Add(books);
            }
            else
            {
                Console.WriteLine("Sorry, that book does not exist in our system.");
            }
        }
      



    }
}
