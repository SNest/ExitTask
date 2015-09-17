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

    public class HotelService : AppService, IHotelService
    {
        private readonly IUnitOfWork unitOfWork;

        public HotelService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<Hotel, HotelDto>();
            Mapper.CreateMap<HotelDto, Hotel>();
        }

        public IEnumerable<HotelDto> GetAllHotels()
        {
            var result = Mapper.Map<List<HotelDto>>(this.unitOfWork.Entities<Hotel, int>().GetAll().ToList());
            return result;
        }

        public IEnumerable<HotelDto> FindHotels(Func<HotelDto, bool> predicate)
        {
            var p = Mapper.Map<Func<Hotel, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<HotelDto>>(this.unitOfWork.Entities<Hotel, int>().Find(p));
            return result;
        }

        public HotelDto GetHotel(int id)
        {
            var result = Mapper.Map<HotelDto>(this.unitOfWork.Entities<Hotel, int>().Get(id));
            return result;
        }

        public void CreateHotel(HotelDto input)
        {
            var instanse = Mapper.Map<Hotel>(input);
            this.unitOfWork.Entities<Hotel, int>().Create(instanse);
        }

        public void UpdateHotel(HotelDto input)
        {
            var instanse = Mapper.Map<Hotel>(input);
            this.unitOfWork.Entities<Hotel, int>().Update(instanse);
        }

        public void DeleteHotel(int id)
        {
            this.unitOfWork.Entities<Hotel, int>().Delete(id);
        }
    }
}