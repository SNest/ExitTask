namespace ExitTask.Application.ApplicationServices.Concrete
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Concrete;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Concrete;

    public class HotelService : GenericService<HotelDto, Hotel, int>, IHotelService
    {
        private readonly IUnitOfWork unitOfWork;

        public HotelService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}