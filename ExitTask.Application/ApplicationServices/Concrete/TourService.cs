namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete.Tour;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Concrete;

    public class TourService : BaseService, ITourService
    {
        private readonly IUnitOfWork unitOfWork;

        public TourService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<TourDetailDto> GetAllTours()
        {
            Mapper.CreateMap<Tour, TourDetailDto>();
            var result = Mapper.Map<List<TourDetailDto>>(this.unitOfWork.Entities<Tour, int>().GetAll().ToList());
            return result;
        }

        
    }
}