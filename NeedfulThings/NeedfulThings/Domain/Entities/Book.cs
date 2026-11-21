namespace BookStore.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int SubjectId { get; set; }
        public string Title
        {
            get; set;
        } = string.Empty;
        public string Isbn
        {
            get; set;
        } = string.Empty;
        public int PageCount
        {
            get; set;
        }
        public int StockQuantity
        {
            get; set;
        }
        public float Price
        {
            get; set;
        }
        public int PublishYear
        {
            get; set;
        }
        public Author? Author
        {
            get; set;
        }
        public Subject? Subject
        {
            get; set;
        }
        ICollection<CaddyItem> CaddyItems { get; set; } = new List<CaddyItem>();
        ICollection<SellerItem> SellerItems { get; set; } = new List<SellerItem>();
    }
}
