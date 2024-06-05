namespace Alina.Models;

public class CardNews : BaseModel
{
    public string Name { get; set; } = String.Empty;
    public DateTime Date { get; set; }
    public string Author { get; set; } = String.Empty;
    public string Hyperlink { get; set; } = String.Empty;
    public Guid SectionID { get; set; }
    public Section Section { get; set; }
    public Guid NewsID { get; set; }
    public News News { get; set; }
}