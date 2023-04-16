namespace CatelogService.Domain.Entities;

public class File
{
    public int FileId { get; set; }

    public string? Path { get; set; }

    public byte[]? Data { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset UpdatedAt { get; set; } 
}