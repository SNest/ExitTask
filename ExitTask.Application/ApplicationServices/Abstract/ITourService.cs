namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete.Tour;

    public interface ITourService
    {
        IEnumerable<TourDetailDto> GetAllTours();
        void Commit();
    }
}