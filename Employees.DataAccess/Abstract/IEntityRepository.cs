using Employees.Entities.Abstract;
using Employees.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void HireAnEmployee(T entity);
        void EjectAnEmployee(T entity);
        void UpdateAnEmloyee(T entity);

    }
}
