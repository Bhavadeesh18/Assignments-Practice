using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void AddBook_ShouldIncreaseBookCount()
        {
            // Arrange
            var library = new Library();
            var book = new Book { ISBN = "123", Title = "Test Book", Author = "Author A" };

            // Act
            library.AddBook(book);
            var books = library.ListBooks();

            // Assert
            Assert.AreEqual(1, books.Count);
        }

        [TestMethod]
        public void RegisterBorrower_ShouldAddBorrower()
        {
            // Arrange
            var library = new Library();
            var borrower = new Borrower { BorrowerId = 1, Name = "John Doe" };

            // Act
            library.RegisterBorrower(borrower);
            var borrowers = library.ListBorrowers();

            // Assert
            Assert.AreEqual(1, borrowers.Count);
        }
    }
}
