namespace BookRentalManagementSystem_V1
{
    internal class Books : Book
    {
        public Books(string bookId, string title, string author, decimal rentalPrice) : base(bookId, title, author, rentalPrice)
        {
        }
    }
}