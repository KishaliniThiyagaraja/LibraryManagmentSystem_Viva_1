using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Book
    {
        private string BookId { get; set; }
        private string Title { get; set; }
        private string Author { get; set; }
        private decimal RentalPrice { get; set; }

        public Book(string bookId, string title, string author, decimal rentalPrice)
        {
            this.BookId = bookId;
            this.Title = title;
            this.Author = author;
            this.RentalPrice = rentalPrice;
        }

        public Book() { }
        public override string ToString()
        {
            return $"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}";
        }
       
    }
}




    
    
   