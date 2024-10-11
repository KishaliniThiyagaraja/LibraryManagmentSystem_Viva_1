using BookRentalManagementSystem_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook : Book
    {
        public int ISBN { get; set; }
        public int NumberOfPages { get; set; }

        public PrintedBook(int iSBN, int numberOfPages)
        {
            ISBN = iSBN;
            NumberOfPages = numberOfPages;
            TotalBooks++;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, ISBN: {ISBN}, NumberOfPages: {NumberOfPages}";
        }
    }
}


