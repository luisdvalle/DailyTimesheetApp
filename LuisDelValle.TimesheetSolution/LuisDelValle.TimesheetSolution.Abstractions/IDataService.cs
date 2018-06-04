using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LuisDelValle.TimesheetSolution.Abstractions
{
    public interface IDataService<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Query(Expression<Func<T, bool>> predicate);
    }
}
