namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;

    public class Route : AuditableEntity<int>
    {
        public Route()
        {
            this.Tours = new HashSet<Tour>();
            this.Cities = new HashSet<City>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}