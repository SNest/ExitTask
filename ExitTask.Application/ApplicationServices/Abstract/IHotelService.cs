namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface IHotelService : IAppService
    {
        IEnumerable<HotelDto> GetAllHotels();

        IEnumerable<HotelDto> FindHotels(Func<HotelDto, bool> predicate);

        HotelDto GetHotel(int id);

        void CreateHotel(HotelDto input);

        void UpdateHotel(HotelDto input);

        void DeleteHotel(int id);
    }
}