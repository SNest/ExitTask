namespace ExitTask.Application.DTOs.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class CountryDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Capital { get; set; }

        public string Population { get; set; }

        public string Geography { get; set; }

        public string Climate { get; set; }

        public string Language { get; set; }

        public string Worship { get; set; }

        public string PoliticalStructure { get; set; }

        public string TimeZone { get; set; }

        public string Currency { get; set; }

        public CountryDtoMainland Mainland { get; set; }

        public ICollection<CityDto> Cities { get; set; }
    }
}
