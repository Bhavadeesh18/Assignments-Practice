using System.Collections.Generic;

public class Borrower
{
    public string Name { get; set; }
    public string LibraryCardNumber { get; set; }
    public List<Book> BorrowedBooks { get; private set; }

    public int BorrowerId { get; set; }      

    public Borrower()
    {
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        if (!book.IsBorrowed)
        {
            book.Borrow();
            BorrowedBooks.Add(book);
        }
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            book.Return();
            BorrowedBooks.Remove(book);
        }
    }
}
