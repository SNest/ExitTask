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

    public class CityService : AppService, ICityService
    {
        private readonly IUnitOfWork unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<CityDto, City>();
        }

        public IEnumerable<CityDto> GetAllCitys()
        {
            var result = Mapper.Map<List<CityDto>>(
                this.unitOfWork.Entities<City, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<CityDto> FindCitys(Func<CityDto, bool> predicate)
        {
            var p = Mapper.Map<Func<City, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<CityDto>>(this.unitOfWork.Entities<City, int>().Find(p));
            return result;
        }

        public CityDto GetCity(int id)
        {
            var result = Mapper.Map<CityDto>(this.unitOfWork.Entities<City, int>().Get(id));
            return result;
        }

        public void CreateCity(CityDto input)
        {
            var instanse = Mapper.Map<City>(input);
            this.unitOfWork.Entities<City, int>().Create(instanse);
        }

        public void UpdateCity(CityDto input)
        {
            var instanse = Mapper.Map<City>(input);
            this.unitOfWork.Entities<City, int>().Update(instanse);
        }

        public void DeleteCity(int id)
        {
            this.unitOfWork.Entities<City, int>().Delete(id);
        }
    }
}
