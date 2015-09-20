namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Models;
    using System.Web.Mvc;

    public class TourViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public TourDtoType Type { get; set; }

        public DateTime BeginDepartureTime { get; set; }

        public DateTime BeginArrivalTime { get; set; }

        public DateTime EndDepartureTime { get; set; }

        public DateTime EndArrivalTime { get; set; }

        public int PersonNumber { get; set; }

        public TourDtoFeeding Feeding { get; set; }

        public decimal Price { get; set; }

        public TourDtoState State { get; set; }

        public byte[] Image { get; set; }
        
        public int? StartCityId { get; set; }

        public int? EndCityId { get; set; }

        public int? HotelId { get; set; }

        public CityDto StartCity { get; set; }

        public CityDto FinishCity { get; set; }

        public HotelDto Hotel { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

        public IEnumerable<SelectListItem> Hotels { get; set; }
    }
}