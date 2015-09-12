namespace ExitTask.Application.DTOs.Concrete.Tour
{
    using System;

    using ExitTask.Domain.Entities.Concrete.Enums;

    class TourPreviewDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime NightNumber { get; set; }

        public decimal Price { get; set; }

        public RouteDto Route { get; set; }
       
        public TourState State { get; set; }
    }
}
