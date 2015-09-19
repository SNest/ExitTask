namespace ExitTask.Presentation.Models
{
    public interface IViewModel<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}