namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Concrete;

    public class CountryService : AppService, ICountryService
    {
        private readonly IUnitOfWork unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<Country, CountryDto>();
            Mapper.CreateMap<CountryDto, Country>();
        }

        public IEnumerable<CountryDto> GetAllCountries()
        {
            var result = Mapper.Map<List<CountryDto>>(this.unitOfWork.Entities<Country, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<CountryDto> FindCountries(Func<CountryDto, bool> predicate)
        {
            var t = Mapper.Map<Func<Country, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<CountryDto>>(this.unitOfWork.Entities<Country, int>().Find(t));
            return result;
        }

        public CountryDto GetCountry(int id)
        {
            var result = Mapper.Map<CountryDto>(this.unitOfWork.Entities<Country, int>().Get(id));
            return result;
        }

        public void CreateCountry(CountryDto input)
        {
            var instanse = Mapper.Map<Country>(input);
            this.unitOfWork.Entities<Country, int>().Create(instanse);
        }

        public void UpdateCountry(CountryDto input)
        {
            var instanse = Mapper.Map<Country>(input);
            this.unitOfWork.Entities<Country, int>().Update(instanse);
        }

        public void DeleteCountry(int id)
        {
            this.unitOfWork.Entities<Country, int>().Delete(id);
        }
    }
}