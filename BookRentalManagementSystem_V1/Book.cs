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
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal RentalPrice { get; set; }
        public int TotalBooks { get; set; }



        public Book(int bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
            TotalBooks++;

        }

        public Book() { }

        public override string ToString()
        {
            return $"ID: {BookId}, Title: {Title}, Author: {Author}, RentalPrice: {RentalPrice:C}";
        }
    }
}








