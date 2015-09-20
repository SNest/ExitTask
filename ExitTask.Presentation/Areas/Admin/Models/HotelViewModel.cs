namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Models;

    public class HotelViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public HotelDtoType Type { get; set; }

        public int Stars { get; set; }

        public int CityId { get; set; }

        public CityDto City { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}
