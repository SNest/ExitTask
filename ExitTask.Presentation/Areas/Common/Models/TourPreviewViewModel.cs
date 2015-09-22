namespace ExitTask.Presentation.Areas.Common.Models
{
    using System;

    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Models;

    public class TourPreviewViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime BeginDepartureTime { get; set; }

        public DateTime EndArrivalTime { get; set; }

        public decimal Price { get; set; }

        public TourDtoState State { get; set; }

        public byte[] Image { get; set; }

    }
}