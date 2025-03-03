using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject.LibraryManagementSystem
{
    public class PrintedBook : Book
    {
        public string BookTitle
        { 
            get; set; 
        }

        public string BookAuthor
        {
            get; set;
        }

        public string BookISBN
        {
            get; set;
        }

        /// <summary>
        /// Constructs a printed book with title, author, and ISBN information.
        /// </summary>
        /// <param name="bookTitle"></param>
        /// <param name="bookAuthor"></param>
        /// <param name="bookISBN"></param>
        
        public PrintedBook(string bookTitle, string bookAuthor, string bookISBN)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            BookISBN = bookISBN;
            
        }

        public override void DisplayBookInfo()
        {
            Console.WriteLine("Here is the book information for you: ");
        }


    }
}
