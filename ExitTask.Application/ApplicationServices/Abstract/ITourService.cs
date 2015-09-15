namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface ITourService : IGenericService<TourDto, int>
    {
        IEnumerable<TourPreviewDto> GetPreviews();
    }
}