namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public interface IListMover<Book>
    {
        void Move(Book newBook, List<Book> ownedBooks, List<Book> unavailableBooks);
        
    }
}
