namespace ExitTask.Application.ApplicationServices.Abstract
{
    using ExitTask.Domain.Abstract.UnitOfWork;

    public abstract class BaseService
    {
        private readonly IUnitOfWork unitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Commit()
        {
            this.unitOfWork.Commit();
        }
    }
}