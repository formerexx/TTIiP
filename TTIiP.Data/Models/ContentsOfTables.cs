namespace Alina.Models;

public class ContentsOfTables:  BaseModel
{
    public string Content { get; set; } = String.Empty;
    public Guid  HeadingId { get; set; }
    public Heading Heading { get; set; }
}