namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete.Enum;

    internal class CountryViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public CountryDtoMainland Mainland { get; set; }

        public ICollection<CityViewModel> Cities { get; set; }
    }
}