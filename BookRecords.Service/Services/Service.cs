using BookRecords.Core.Repositories;
using BookRecords.Core.Services;
using BookRecords.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecords.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
            _unitOfWork.Commit();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
