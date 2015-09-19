namespace ExitTask.Presentation.Models
{
    public class ViewModel<TPrimaryKey> : IViewModel<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}