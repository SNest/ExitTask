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
    using ExitTask.Domain.Entities.Concrete.Enum;

    public class TourService : AppService, ITourService
    {
        private readonly IUnitOfWork unitOfWork;

        public TourService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<Tour, TourDto>();
            Mapper.CreateMap<TourDto, Tour>();
            Mapper.CreateMap<Tour, TourPreviewDto>();
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<CityDto, City>();
            Mapper.CreateMap<Country, CountryDto>();
            Mapper.CreateMap<CountryDto, Country>();
            Mapper.CreateMap<User, UserDto>();
            Mapper.CreateMap<UserDto, User>();
            Mapper.CreateMap<Hotel, HotelDto>();
            Mapper.CreateMap<HotelDto, Hotel>();
        }

        public IEnumerable<TourPreviewDto> GetTourPreviews()
        {
            var result = Mapper.Map<List<TourPreviewDto>>(this.unitOfWork.Entities<Tour, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<TourDto> GetAllTours()
        {
            var result = Mapper.Map<List<TourDto>>(this.unitOfWork.Entities<Tour, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<TourDto> FindTours(Func<TourDto, bool> predicate)
        {
            var p = Mapper.Map<Func<Tour, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<TourDto>>(this.unitOfWork.Entities<Tour, int>().Find(p));
            return result;
        }

        public TourDto GetTour(int id)
        {
            var result = Mapper.Map<TourDto>(this.unitOfWork.Entities<Tour, int>().Get(id));
            return result;
        }

        public IEnumerable<TourDto> GetToursByUserId(int id)
        {
            var result =
                Mapper.Map<IEnumerable<TourDto>>(
                    this.unitOfWork.Entities<Tour, int>().Find(tour => tour.CustomerId == id));
            return result;
        }

        public void CreateTour(TourDto input)
        {
            var instanse = Mapper.Map<Tour>(input);
            this.unitOfWork.Entities<Tour, int>().Create(instanse);
        }

        public void UpdateTour(TourDto input)
        {
            var instanse = Mapper.Map<Tour>(input);
            this.unitOfWork.Entities<Tour, int>().Update(instanse);
        }

        public void DeleteTour(int id)
        {
            this.unitOfWork.Entities<Tour, int>().Delete(id);
        }

        public IEnumerable<TourDto> GetBookedTours()
        {
            var result =
                Mapper.Map<List<TourDto>>(
                    this.unitOfWork.Entities<Tour, int>().Find(tour => tour.State == TourState.Booked));
            return result;
        }
    }
}