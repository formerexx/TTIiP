namespace Alina.Models;

public class Section: BaseModel
{
    public string Name { get; set; } = string.Empty;
    
    public List<SectionItem> SectionItems { get; set; }
    
    public List<CardNews> CardNews { get; set; }
    
}