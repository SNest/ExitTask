namespace ExitTask.Domain.Entities.Concrete
{
    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Hotel : Entity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public HotelType Type { get; set; }

        public int Stars { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}