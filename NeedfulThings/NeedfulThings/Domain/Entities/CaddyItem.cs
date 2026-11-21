namespace BookStore.Domain.Entities
{
    public class CaddyItem
    {
        public int Id { get; set; }
        public int CaddyId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public Caddy? Caddy
        {
            get; set;
        }
        public Book? Book
        {
            get; set;
        }
    }
}
