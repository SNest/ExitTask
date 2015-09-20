namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Application.DTOs.Concrete;

    public interface ICityService : IAppService
    {
        IEnumerable<CityDto> GetAllCitys();

        IEnumerable<CityDto> FindCitys(Func<CityDto, bool> predicate);

        CityDto GetCity(int id);

        void CreateCity(CityDto input);

        void UpdateCity(CityDto input);

        void DeleteCity(int id);
    }
    
}
