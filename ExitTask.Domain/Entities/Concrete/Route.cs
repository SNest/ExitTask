namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ExitTask.Domain.Entities.Abstract;

    public class Route : AuditableEntity<int>
    {
        public Route()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Id")]
        public virtual Tour Tour { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}