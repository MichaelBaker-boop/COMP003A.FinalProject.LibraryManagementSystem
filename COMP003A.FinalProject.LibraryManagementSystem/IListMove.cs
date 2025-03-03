namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public interface IListMove<Book>
    {
        void Checkout(Book books, List<Book> ownedBooks, List<Book> unavailableBooks);
        void Return (Book books, List<Book> unavailableBooks, List<Book> ownedBooks);
    }
}
