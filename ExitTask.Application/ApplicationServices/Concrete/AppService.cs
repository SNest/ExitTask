namespace ExitTask.Application.ApplicationServices.Concrete
{
    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Domain.Abstract.UnitOfWork;

    public class AppService : IAppService
    {
        private readonly IUnitOfWork unitOfWork;

        public AppService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Commit()
        {
            this.unitOfWork.Commit();    
        }
    }
}
