namespace ExitTask.Application.DTOs.Concrete.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum TourDtoState
    {
        [Display(Name = "   -   ")]
        None = 0,

        [Display(Name = "Обычный")]
        Hot = 1,

        [Display(Name = "Горящий")]
        Normal = 2,

        [Display(Name = "Зарегистрированный")]
        Booked = 3,

        [Display(Name = "Оплаченный")]
        Paid = 4,

        [Display(Name = "Отменен")]
        Rejected = 5
    }
}