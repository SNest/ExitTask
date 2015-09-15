namespace ExitTask.Application.ApplicationServices.Abstract
{
    using System;
    using System.Collections.Generic;

    using ExitTask.Application.DTOs.Abstract;

    public interface IGenericService<TEntityDto, in TPrimaryKey>
        where TEntityDto : class, IEntityDto<TPrimaryKey>
    {
        IEnumerable<TEntityDto> GetAll();

        TEntityDto Get(TPrimaryKey id);

        IEnumerable<TEntityDto> Find(Func<TEntityDto, Boolean> predicate);

        void Create(TEntityDto input);

        void Update(TEntityDto input);

        void Delete(TPrimaryKey id);

        void Commit();
    }
}