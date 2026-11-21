namespace BookStore.Domain.Entities
{
    public class SellerItem
    {
        public int SellerId { get; set; }
        public int BookId { get; set; }
        public int QuantityInStock { get; set; }
        public Seller? Seller
        {
            get; set;
        }
        public Book? Book
        {
            get; set;
        }
    }
}
