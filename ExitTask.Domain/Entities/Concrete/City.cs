namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;

    public class City : Entity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public Guid CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}