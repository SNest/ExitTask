namespace ExitTask.Application.ApplicationServices.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using ExitTask.Application.ApplicationServices.Abstract;
    using ExitTask.Application.DTOs.Abstract;
    using ExitTask.Domain.Abstract.UnitOfWork;
    using ExitTask.Domain.Entities.Abstract;

    public class GenericService<TEntityDto, TEntity, TPrimaryKey> : IGenericService<TEntityDto, TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly IUnitOfWork unitOfWork;

        public GenericService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            Mapper.CreateMap<TEntity, TEntityDto>();
            Mapper.CreateMap<TEntityDto, TEntity>();
        }

        public virtual IEnumerable<TEntityDto> GetAll()
        {
            var result = Mapper.Map<List<TEntityDto>>(
                this.unitOfWork.Entities<TEntity, TPrimaryKey>().GetAll().ToList());
            return result;
        }

        public virtual TEntityDto Get(TPrimaryKey id)
        {
            var result = Mapper.Map<TEntityDto>(this.unitOfWork.Entities<TEntity, TPrimaryKey>().Get(id));
            return result;
        }

        public virtual IEnumerable<TEntityDto> Find(Func<TEntityDto, bool> predicate)
        {
            var t = Mapper.Map<Func<TEntity, bool>>(predicate);
            var result = Mapper.Map<IEnumerable<TEntityDto>>(this.unitOfWork.Entities<TEntity, TPrimaryKey>().Find(t));
            return result;
        }

        public virtual void Create(TEntityDto input)
        {
            var hotel = Mapper.Map<TEntity>(input);
            this.unitOfWork.Entities<TEntity, TPrimaryKey>().Create(hotel);
        }

        public virtual void Update(TEntityDto input)
        {
            var hotel = Mapper.Map<TEntity>(input);
            this.unitOfWork.Entities<TEntity, TPrimaryKey>().Update(hotel);
        }

        public virtual void Delete(TPrimaryKey id)
        {
            this.unitOfWork.Entities<TEntity, TPrimaryKey>().Delete(id);
        }

        public void Commit()
        {
            this.unitOfWork.Commit();
        }
    }
}