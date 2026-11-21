namespace BookStore.Domain.Entities
{
    public class Author
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
        public DateOnly BirthDate
        {
            get; set;
        }
        public ICollection<Book> Books
        {
            get; set;
        } = new List<Book>();
    }
}
