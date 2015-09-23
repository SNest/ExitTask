namespace ExitTask.Presentation.Areas.Common.Models
{
    using ExitTask.Application.DTOs.Concrete.Enum;
    using ExitTask.Presentation.Models;

    public class FilterTourViewModel : ViewModel<int>
    {
        public TourDtoType Type { get; set; }

        public decimal Price { get; set; }

        public HotelDtoType Hotel { get; set; }
    }
}