using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories.Interface;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Repositories.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected EmployeeDbContext _entities;
        protected readonly DbSet<T> _dbset;

        //public GenericRepository()
        //{
        //    this.db = new EmployeeDbContext();
        //    table = db.Set<T>();
        //}


        public GenericRepository(EmployeeDbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return _dbset.ToList();
        }
        //public T SelectByID(object id)
        //{
        //    return table.Find(id);
        //}
        public Boolean Insert(T obj)
        {
            _dbset.Add(obj);
            return true;
        }
        public Boolean Update(T obj)
        {
            _dbset.Attach(obj);
            _entities.Entry(obj).State = EntityState.Modified;
            return true;
        }
        //public void Delete(object id)
        //{
        //    T existing = _dbset.Where(x => x.EmpID == id).FirstOrDefault();
        //    _dbset.Remove(existing);
        //}
        public void Save()
        {
            _entities.SaveChanges();
        }
    }
}
