namespace ExitTask.Presentation.Areas.Admin.Models
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Areas.Admin.Validators;
    using ExitTask.Presentation.Models;

    using FluentValidation.Attributes;

    [Validator(typeof(CountryViewModelValidator))]
    public class CountryViewModel : ViewModel<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public CountryDtoMainland Mainland { get; set; }

        public ICollection<CityViewModel> Cities { get; set; }
    }

    
}