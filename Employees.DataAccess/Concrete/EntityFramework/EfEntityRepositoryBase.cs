using Employees.DataAccess.Abstract;
using Employees.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employees.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void EjectAnEmployee(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var ejectedEmployee = context.Entry(entity);
                ejectedEmployee.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context= new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntity>().ToList():
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void HireAnEmployee(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var hiredEmployee = context.Entry(entity);
                hiredEmployee.State = EntityState.Added;
                context.SaveChanges();
                
            }
        }

        public void UpdateAnEmloyee(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEmployee = context.Entry(entity);
                updatedEmployee.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
