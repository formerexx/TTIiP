namespace Alina.Models;

public class Content: BaseModel
{
    public string Description { get; set; } = String.Empty;
    public string Hyperlink { get; set; } = String.Empty;
    public Guid SectionItemID { get; set; }
    public SectionItem SectionItem { get; set; }
    public Guid HeadingID { get; set; }
    public Heading Heading { get; set; }
}