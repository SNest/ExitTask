namespace ExitTask.Application.DTOs.Concrete
{
    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class HotelDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public HotelDtoType Type { get; set; }

        public int Stars { get; set; }

        public int? CityId { get; set; }

        public CityDto City { get; set; }
    }
}
