namespace ExitTask.Application.DTOs.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class CountryDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public CountryDtoMainland Mainland { get; set; }

        public ICollection<CityDto> Cities { get; set; }
    }
}
