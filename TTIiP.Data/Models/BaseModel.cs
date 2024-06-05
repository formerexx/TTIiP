namespace Alina.Models;

public abstract class BaseModel: IBaseModel
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
        DateCreate = DateTime.Now;
        UpDateChange = DateTime.Now;
    }
    
    public Guid Id { get; }
    public DateTime DateCreate { get; }
    public DateTime UpDateChange { get; }
}