namespace ExitTask.Domain.Entities.Abstract
{
    using System;

    public abstract class AuditableEntity<TPrimaryKey> : Entity<TPrimaryKey>, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedByUserId { get; set; }
    }
}