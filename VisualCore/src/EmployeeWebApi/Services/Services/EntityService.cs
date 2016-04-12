using EmployeeWebApi.Repositories.Interface;
using EmployeeWebApi.Services.Interface;
using System;
using System.Collections.Generic;

namespace EmployeeWebApi.Services.Services
{
    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        IUnitOfWorks _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWorks unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }


        public virtual Boolean Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Boolean res = _repository.Insert(entity);
            _unitOfWork.Commit();
            return res;
        }


        public virtual Boolean Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            Boolean res = _repository.Update(entity);
            _unitOfWork.Commit();
            return res;
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
          // _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.SelectAll();
        }
    }
}
