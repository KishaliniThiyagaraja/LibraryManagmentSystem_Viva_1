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
        private string bookId { get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private decimal rentalPrice { get; set; }

        public Book(string bookId, string title, string author, decimal rentalPrice)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.rentalPrice = rentalPrice;
        }
    }
}

    
   