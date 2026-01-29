namespace Pustok.Business.Dtos;

public class CategoryGetDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<ProductGetDto> Products { get; set; } = [];
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? DeletedBy { get; set; }
    public DateTime? DeletedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}
