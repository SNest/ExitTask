namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Domain.Entities.Abstract;

    public class City : Entity<int>
    {
        public City()
        {
            this.Hotels = new List<Hotel>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}