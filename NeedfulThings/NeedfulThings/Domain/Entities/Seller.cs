namespace BookStore.Domain.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name
        {
            get; set;
        } = string.Empty;
        public string Vat { get; set; } = string.Empty;
        ICollection<SellerItem> SellerItems { get; set; } = new List<SellerItem>();
    }
}
