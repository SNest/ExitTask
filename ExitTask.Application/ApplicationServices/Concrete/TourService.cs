namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System.Collections.Generic;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
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

        public IEnumerable<TourDto> GetAllTours()
        {
            var result = Mapper.Map<List<TourDto>>(this.unitOfWork.Entities<Tour, int>().GetAll());
            return result;
        }
    }
}