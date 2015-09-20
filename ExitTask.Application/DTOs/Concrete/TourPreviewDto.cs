namespace ExitTask.Application.DTOs.Concrete
{
    using System;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete.Enum;

    public class TourPreviewDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourDtoType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime NightNumber { get; set; }

        public decimal Price { get; set; }
       
        public TourDtoState State { get; set; }
    }
}
