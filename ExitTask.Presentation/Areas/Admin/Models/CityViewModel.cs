namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Presentation.Models;
    using System.Web.Mvc;


    public class CityViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int CountryId { get; set; }

        public CountryDto Country { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public IEnumerable<HotelDto> Hotels { get; set; }
    }
}
