namespace BookStore.Domain.Exceptions
{
    public class ConflicException(string message) : Exception(message)
    {
    }
}
