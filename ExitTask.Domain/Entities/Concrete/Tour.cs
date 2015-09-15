namespace ExitTask.Domain.Entities.Concrete
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Tour : Entity<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TourType Type { get; set; }

        [Required]
        public DateTime BeginDepartureTime { get; set; }

        [Required]
        public DateTime BeginArrivalTime { get; set; }

        [Required]
        public DateTime EndDepartureTime { get; set; }

        [Required]
        public DateTime EndArrivalTime { get; set; }

        [Required]
        [Range(1, 12)]
        public int PersonNumber { get; set; }

        [Required]
        public TourFeeding Feeding { get; set; }

        [Required]
        [Range(100, 200000)]
        public decimal Price { get; set; }

        [Required]
        public TourState State { get; set; }

        public int? CustomerId { get; set; }

        public int? StartCityId { get; set; }

        public int? EndCityId { get; set; }

        public int? HotelId { get; set; }

        public byte[] Image { get; set; }

        public virtual User Customer { get; set; }

        public virtual City StartCity { get; set; }

        public virtual City FinishCity { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}