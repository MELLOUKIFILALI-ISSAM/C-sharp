namespace BookStore.Domain.Entities
{
    public class Caddy
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public bool Payed { get; set; }
        public Client? Client
        {
            get; set;
        }
        ICollection<CaddyItem> CaddyItems { get; set; } = new List<CaddyItem>();
    }
}
