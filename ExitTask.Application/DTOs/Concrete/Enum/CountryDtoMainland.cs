namespace ExitTask.Application.DTOs.Concrete.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum CountryDtoMainland
    {
        [Display(Name = "   -   ")]
        None = 0,

        [Display(Name = "Европа")]
        Europe = 1,

        [Display(Name = "Азия")]
        Asia = 2,

        [Display(Name = "Африка")]
        Africa = 3,

        [Display(Name = "Северная Америка")]
        NorthAmerica = 4,

        [Display(Name = "Южная Америка")]
        SouthAmerica = 5,

        [Display(Name = "Австралия")]
        Australia = 6
    }
}