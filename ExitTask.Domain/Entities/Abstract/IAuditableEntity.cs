using System;

namespace ExitTask.Domain.Entities.Abstract
{
    interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }

        int CreatedByUserId { get; set; }

        DateTime UpdatedDate { get; set; }

        int UpdatedByUserId { get; set; }
    }
}
