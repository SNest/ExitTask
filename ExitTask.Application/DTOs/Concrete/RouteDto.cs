namespace ExitTask.Application.DTOs.Concrete
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;

    public class RouteDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<TourDto> Tours { get; set; }

        public ICollection<CityDto> Cities { get; set; }
    }
}
