using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<Borrower> borrowers;

        public Library()
        {
            books = new List<Book>();
            borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> ListBooks()
        {
            return books;
        }

        public void RegisterBorrower(Borrower borrower)
        {
            borrowers.Add(borrower);
        }

        public List<Borrower> ListBorrowers()
        {
            return borrowers;
        }
    }
}
