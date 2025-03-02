using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public abstract class Book
    {
        // Fields
        private string _bookTitle;
        private string _bookAuthor;
        private string _bookISBN;


        // Properties
        public string Title
        {
            get
            {
                return _bookTitle;
            }
            set
            {
                _bookTitle = value;
            }
        }

        public string Author
        {
            get
            {
                return _bookAuthor;
            }
            set
            {
                _bookAuthor = value;
            }
        }

        public string ISBN
        {
            get
            {
                return _bookISBN;
            }
            set
            {
                _bookISBN = value;
            }
        }

        public abstract void DisplayBookInfo();

    }
}
