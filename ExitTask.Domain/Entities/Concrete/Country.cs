namespace ExitTask.Domain.Entities.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Country : Entity<int>
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        public string Name { get; set; }

        public string Capital { get; set; }

        public string Population { get; set; }

        public string Geography { get; set; }

        public string Climate { get; set; }

        public string Language { get; set; }

        public string Worship { get; set; }

        public string PoliticalStructure { get; set; }

        public string TimeZone { get; set; }

        public string Currency { get; set; }

        public CountryMainland Mainland { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}