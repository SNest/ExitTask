namespace ExitTask.Application.Mapping
{
    public class Source<TEntity> where TEntity : class 
    {
        public TEntity Value { get; set; }
    }
}
