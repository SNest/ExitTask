namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;

    public class Country : Entity<Guid>
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}