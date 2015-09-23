namespace ExitTask.Application.DTOs.Concrete.Enum
{
    using System.ComponentModel.DataAnnotations;

    public enum TourDtoState
    {
        [Display(Name = "   -   ")]
        None = 0,

        [Display(Name = "Обычный")]
        Normal = 1,

        [Display(Name = "Горящий")]
        Hot = 2,

        [Display(Name = "Зарегистрированный")]
        Booked = 3,

        [Display(Name = "Оплаченный")]
        Paid = 4,

        [Display(Name = "Отменен")]
        Rejected = 5
    }
}