using System.Runtime.Serialization;

namespace CatelogService.Domain.Exceptions;

public class InvalidMarkdownException : Exception
{
    public InvalidMarkdownException()
    {
    }

    public InvalidMarkdownException(string? message) : base(message)
    {
    }

    public InvalidMarkdownException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidMarkdownException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
