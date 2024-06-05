namespace Alina.Models;

public class Heading : BaseModel
{
    public string ContentHeading { get; set; } = String.Empty;
    public Guid ContentID { get; set; }
    public Content Content{ get; set; }
    public Guid ContentOfTablesID { get; set; }
    public ContentsOfTables ContentsOfTablesID { get; set; }
}