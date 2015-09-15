namespace ExitTask.Application.DTOs.Concrete
{
    using ExitTask.Application.DTOs.Abstract;

    public class HotelDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }

        public int Stars { get; set; }

        public CityDto City { get; set; }
    }
}
