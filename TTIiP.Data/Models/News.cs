namespace Alina.Models;

public class News : BaseModel
{
    public string Content { get; set; } = String.Empty;
    public Guid CardNewsID { get; set; }
    public CardNews CardNews { get; set; }
}