namespace BookStore.Domain.Exceptions
{
    public class ValidationException(string message) : Exception(message)
    {
    }
}
