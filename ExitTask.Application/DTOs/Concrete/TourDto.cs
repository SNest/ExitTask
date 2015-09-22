namespace ExitTask.Application.DTOs.Concrete
{
    using System;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class TourDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourDtoType Type { get; set; }

        public DateTime BeginDepartureTime { get; set; }

        public DateTime BeginArrivalTime { get; set; }

        public DateTime EndDepartureTime { get; set; }

        public DateTime EndArrivalTime { get; set; }

        public int PersonNumber { get; set; }

        public TourDtoFeeding Feeding { get; set; }

        public decimal Price { get; set; }

        public TourDtoState State { get; set; }

        public byte[] Image { get; set; }

        public int? CustomerId { get; set; }

        public int? StartCityId { get; set; }

        public int? FinishCityId { get; set; }

        public int? HotelId { get; set; }

        public UserDto Customer { get; set; }

        public CityDto StartCity { get; set; }

        public CityDto FinishCity { get; set; }

        public HotelDto Hotel { get; set; }

    }
}
