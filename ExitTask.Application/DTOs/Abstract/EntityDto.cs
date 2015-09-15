namespace ExitTask.Application.DTOs.Abstract
{
    public abstract class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
