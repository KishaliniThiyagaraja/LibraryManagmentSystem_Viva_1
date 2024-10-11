using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {

        private List<Book> books = new List<Book>();
        private int nextId = 1;


        public void CreateBook(string title, string author, decimal rentalPrice)
        {



            var Book = new Books(nextId++, title, author, rentalPrice);
            books.Add(Book);

            Console.WriteLine("Book added successfully!");

        }




        public void ReadBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }


            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} {book.bookId} {book.rentalPrice} {book.author}");
            }
        }

        public void UpdateBook(int bookId, string newTitle, string newAuthor, decimal c)
        {
            var book = books.Find(b => b.bookId == bookId);
            if (book != null)
            {


                books.Add(new Book(bookId, newTitle, newAuthor, newRentalPrice));
                Console.WriteLine("Book updated successfully!");
            }

            else
            {
                Console.WriteLine("Book not found.");
            }

            if (book != null)
            {
                book.BookId = bookId;
                book.author = newAuthor;
                book.title = newTitle;
                book.rentalPrice = c;

            }

        }

        public void DeleteBook(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully!");
            }



            else
            {
                Console.WriteLine("Book not found.");
            }

        }


    }


}











