namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class User : AuditableEntity<int>
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [Required]
        public Role Role { get; set; }

        public Guid? CityId { get; set; }

        public virtual City City { get; set; }
    }
}