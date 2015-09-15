namespace ExitTask.Application.Mapping
{
    public class Destination<TEntity> where TEntity : class
    {
        public TEntity Value { get; set; }
    }
}
