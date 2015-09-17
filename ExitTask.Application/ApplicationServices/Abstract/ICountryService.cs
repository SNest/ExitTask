namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Concrete;

    public interface ICountryService : IAppService
    {
        IEnumerable<CountryDto> GetAllCountries();

        IEnumerable<CountryDto> FindCountries(Func<CountryDto, bool> predicate);

        CountryDto GetCountry(int id);

        void CreateCountry(CountryDto input);

        void UpdateCountry(CountryDto input);

        void DeleteCountry(int id);
    }
}