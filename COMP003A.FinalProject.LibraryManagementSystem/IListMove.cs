namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public interface IListMove<Book>
    {
        void MoveItem(Book books, List<Book> ownedBooks, List<Book> unavailableBooks);
        
    }
}
