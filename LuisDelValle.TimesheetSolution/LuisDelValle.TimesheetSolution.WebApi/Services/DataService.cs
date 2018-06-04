using LuisDelValle.TimesheetSolution.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LuisDelValle.TimesheetSolution.WebApi.Services
{
    public class DataService<T> : IDataService<T> where T : class
    {
        private TimesheetDbContext _dbContext;
        private DbSet<T> _dbSet;

        public DataService(TimesheetDbContext dbContext, DbSet<T> dbSet = null)
        {
            _dbContext = dbContext;
            if (dbSet == null)
            {
                _dbSet = _dbContext.Set<T>();
            }
            else
            {
                _dbSet = dbSet;
            }
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
    }
}
