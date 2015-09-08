namespace ExitTask.Domain.Entities.Abstract
{
    using System.ComponentModel.DataAnnotations;

    public abstract class BaseEntity
    {
    }

    public abstract class Entity<TPrimaryKey> : BaseEntity, IEntity<TPrimaryKey>
    {
        [Key]
        public virtual TPrimaryKey Id { get; set; }
    }
}