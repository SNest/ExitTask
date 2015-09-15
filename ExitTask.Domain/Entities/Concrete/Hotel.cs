namespace ExitTask.Domain.Entities.Concrete
{
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Hotel : Entity<int>
    {
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public HotelType Type { get; set; }

        [Required]
        [Range(0, 7)]
        public int Stars { get; set; }

        public int? CityId { get; set; }

        public virtual City City { get; set; }
    }
}