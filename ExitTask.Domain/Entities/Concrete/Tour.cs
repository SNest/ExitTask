namespace ExitTask.Domain.Entities.Concrete
{
    using System;

    using ExitTask.Domain.Entities.Abstract;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class Tour : Entity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourType Type { get; set; }

        public DateTime BeginDepartureTime { get; set; }

        public DateTime BeginArrivalTime { get; set; }

        public DateTime EndDepartureTime { get; set; }

        public DateTime EndArrivalTime { get; set; }

        public int PersonNumber { get; set; }

        public TourFeeding Feeding { get; set; }

        public decimal Price { get; set; }

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