namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Country : Entity<int>
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public CountryMainland Mainland { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}