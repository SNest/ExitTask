namespace ExitTask.Application.DTOs.Concrete.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum HotelDtoType
    {
        [Display(Name = "   -   ")]
        None = 0,

        [Display(Name = "Бизнес")]
        Business = 1,

        [Display(Name = "Апартаменты")]
        Apartment = 2,

        [Display(Name = "Хостел")]
        Hostel = 3,

        [Display(Name = "Spa")]
        Spa = 4,

        [Display(Name = "Шале")]
        Chalet = 5
    }
}