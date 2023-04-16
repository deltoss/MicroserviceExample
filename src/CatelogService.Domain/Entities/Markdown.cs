namespace CatelogService.Domain.Entities;

public class Markdown 
{
    public int MarkdownId { get; set; }

    public string? Content { get; set; }

    public string? Author { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }
}

