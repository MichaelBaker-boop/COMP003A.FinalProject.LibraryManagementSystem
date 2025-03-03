namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public abstract class CheckoutOrReturn<Book> : IListMove<Book>
    {
        public abstract void Checkout(Book books, List<Book> ownedBooks, List<Book> unavailableBooks);
        {
            if (ownedBooks.Contains(Book))
            {
                ownedBooks.Remove(Book)
            
            }
        }

    }
}
