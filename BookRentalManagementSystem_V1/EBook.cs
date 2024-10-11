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
        public double FileSize { get; }
        public string Format { get; }


        public EBook(int bookId, string title, string author, decimal rentalPrice, double fileSize, string format)
            : base(bookId, title, author, rentalPrice)
        {
            FileSize = fileSize;
            Format = format;

        }

        public override string ToString()
        {
            return $"{base.ToString()}, FileSize: {FileSize}MB, Format: {Format}";
        }
    }
}




