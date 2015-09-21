namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Areas.Admin.Validators;
    using ExitTask.Presentation.Models;

    using FluentValidation.Attributes;
    using System.Web.Mvc;

    [Validator(typeof(CountryViewModelValidator))]
    public class CountryViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Capital { get; set; }

        public string Population { get; set; }

        public string Geography { get; set; }

        public string Climate { get; set; }

        public string Language { get; set; }

        public string Worship { get; set; }

        public string PoliticalStructure { get; set; }

        public string TimeZone { get; set; }

        public string Currency { get; set; }

        public CountryDtoMainland Mainland { get; set; }

        public IEnumerable<CityViewModel> Cities { get; set; }
    }
}