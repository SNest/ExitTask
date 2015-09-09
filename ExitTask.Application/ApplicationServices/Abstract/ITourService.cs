namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface ITourService
    {
        IEnumerable<TourDto> GetAllTours();
        void Commit();
    }
}