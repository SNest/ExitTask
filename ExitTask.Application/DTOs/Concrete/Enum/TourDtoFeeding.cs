namespace ExitTask.Application.DTOs.Concrete.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum TourDtoFeeding
    {
        [Display(Name = "   -   ")]
        None = 0,

        [Display(Name = "Только завтрак")]
        BedAndBreakfast = 1,

        [Display(Name = "Обед и ужин")]
        BreakfastAndDinner = 2,

        [Display(Name = "Все включено")]
        AllInclusive = 3
    }
}