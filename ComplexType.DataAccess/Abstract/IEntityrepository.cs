using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ComplexType.Entity.Abstract;
using ComplexType.Entity.Concrete;

namespace ComplexType.DataAccess.Abstract
{
    public interface IEntityRepository<T> where  T: class,IEntity,new()
    {
        List<T> GetProducts(Expression<Func<T, bool>> filter = null);
    }
}
