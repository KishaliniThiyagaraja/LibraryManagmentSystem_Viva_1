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
        private int BookId { get; set; }
        private string Title { get; set; }
        private string Author { get; set; }
        private decimal RentalPrice { get; set; }


        private Book(int bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        private Book() { }

        public override string ToString()
        {
            return $"ID: {BookId}, Title: {Title}, Author: {Author}, RentalPrice: {RentalPrice:C}";
        }
    }
}








