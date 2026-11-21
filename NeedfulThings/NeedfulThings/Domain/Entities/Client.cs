namespace BookStore.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName
        {
            get; set;
        } = string.Empty;
        public string FirstName
        {
            get; set;
        } = string.Empty;
        public string Email
        {
            get; set;
        } = string.Empty;
        public string Address
        {
            get; set;
        } = string.Empty;
        public string PostalCode
        {
            get; set;
        } = string.Empty;
        public string City
        {
            get; set;
        } = string.Empty;
        public string Country
        {
            get; set;
        } = string.Empty;
        public string? PhoneNumber
        {
            get; set;
        } = string.Empty;
        ICollection<Caddy> Caddies { get; set; } = new List<Caddy>();
    }
}
