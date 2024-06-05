using Type = Alina.Enums.Type;

namespace Alina.Models;

public class SectionItem : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public Guid SectionID { get; set; }

    public Section Section { get; set; }
    public Type Type { get; set; }
    
    public List<Content> Contents { get; set; }
}