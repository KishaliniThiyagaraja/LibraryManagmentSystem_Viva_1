using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{

    internal class EBook : Book
    {
        public double FileSize { get; set; }
        public string Format { get; set; }
        public int TotalBooks {  get; set; }



        public EBook(string bookId, string title, string author, decimal rentalPrice, double fileSize, string format)
            : base(bookId, title, author, rentalPrice)
        {
            FileSize = fileSize;
            Format = format;
            TotalBooks++;

        }

        public override string ToString()
        {
            return $"{base.ToString()}, FileSize: {FileSize}MB, Format: {Format}";
        }
    }
}




