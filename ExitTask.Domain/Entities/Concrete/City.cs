namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;

    public class City : Entity<int>
    {
        public City()
        {
            this.Hotels = new List<Hotel>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}