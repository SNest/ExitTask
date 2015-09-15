namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Concrete;

    public class TourService : GenericService<TourDto, Tour, int>,  ITourService
    {
        private readonly IUnitOfWork unitOfWork;

        public TourService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<Tour, TourPreviewDto>();
        }

        public IEnumerable<TourPreviewDto> GetPreviews()
        {
            var result = Mapper.Map<List<TourPreviewDto>>(this.unitOfWork.Entities<Tour, int>().GetAll().ToList());
            return result;
        }
    }
}