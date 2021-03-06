﻿namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface ITourService : IAppService
    {
        IEnumerable<TourPreviewDto> GetTourPreviews();
        IEnumerable<TourDto> GetToursByUserId(int id);

        IEnumerable<TourDto> GetAllTours();

        IEnumerable<TourDto> GetBookedTours();

        IEnumerable<TourDto> FindTours(Func<TourDto, bool> predicate);

        TourDto GetTour(int id);

        void CreateTour(TourDto input);

        void UpdateTour(TourDto input);

        void DeleteTour(int id);
    }
}