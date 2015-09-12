namespace ExitTask.Application.DTOs.Concrete.Tour
{
    using System;

    using ExitTask.Domain.Entities.Concrete;
    using ExitTask.Domain.Entities.Concrete.Enums;

    public class TourDetailDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourType Type { get; set; }

        public DateTime StartDate { get; set; }

        public int NightNumber { get; set; }

        public decimal Price { get; set; }

        public TourState State { get; set; }

        public int? RouteId { get; set; }

        public virtual Route Route { get; set; }

        public virtual Picture Picture { get; set; }

    }
}
