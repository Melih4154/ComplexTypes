using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ComplexType.DataAccess.Abstract;
using ComplexType.Entity.Abstract;

namespace ComplexType.DataAccess.Concrete
{
    public class EntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity> 
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public List<TEntity> GetProducts(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
