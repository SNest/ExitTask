namespace ExitTask.Application.DTOs.Concrete
{
    using System.Collections.Generic;

    public class CountryDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<CityDto> Cities { get; set; }
    }
}
