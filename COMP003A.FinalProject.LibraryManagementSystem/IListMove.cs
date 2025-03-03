namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public interface IListMover<PrintedBook>
    {
        void Move(PrintedBook newBook, List<PrintedBook> ownedBooks, List<PrintedBook> unavailableBooks);
        
    }
}
