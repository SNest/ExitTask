namespace ExitTask.Application.DTOs.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;

    public class CityDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public  CountryDto Country { get; set; }

        public ICollection<HotelDto> Hotels { get; set; }
    }
}
