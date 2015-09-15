namespace ExitTask.Application.DTOs.Concrete
{
    using System;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class TourDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourType Type { get; set; }

        public DateTime BeginDepartureTime { get; set; }

        public DateTime BeginArrivalTime { get; set; }

        public DateTime EndDepartureTime { get; set; }

        public DateTime EndArrivalTime { get; set; }

        public int PersonNumber { get; set; }

        public TourDtoFeeding Feeding { get; set; }

        public decimal Price { get; set; }

        public TourDtoState State { get; set; }

        public byte[] Image { get; set; }

        public virtual UserDto Customer { get; set; }

        public virtual CityDto StartCity { get; set; }

        public virtual CityDto FinishCity { get; set; }

        public virtual HotelDto Hotel { get; set; }

    }
}
