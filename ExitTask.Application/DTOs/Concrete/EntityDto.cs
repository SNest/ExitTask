namespace ExitTask.Application.DTOs.Concrete
{
    using ExitTask.Application.DTOs.Abstract;

    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
