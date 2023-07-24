namespace NoDocManager.Abstractions.Models;

public class Document : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string FileLocation { get; set; } = string.Empty;
}
