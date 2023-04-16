namespace CatelogService.Domain.Entities;

public class CatalogItem
{
    public int CatalogItemId { get; set; }

    public string? Name { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public DateTimeOffset CreatedAt { get; set; }

    public DateTimeOffset UpdatedAt { get; set; }
}
