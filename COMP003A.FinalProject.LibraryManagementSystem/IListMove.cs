namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public interface IListMover<Book>
    {
        void Move(Book books, List<Book> ownedBooks, List<Book> unavailableBooks);
        
    }
}
