namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System;

    using ExitTask.Application.DTOs.Concrete.Enum;

    internal class TourListViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourDtoType Type { get; set; }

        public DateTime StartDate { get; set; }

        public int NightNumber { get; set; }

        public TourDtoFeeding Feeding { get; set; }

        public decimal Price { get; set; }

        public TourDtoState State { get; set; }

        public int? RouteId { get; set; }

        public byte[] Image { get; set; }
    }
}