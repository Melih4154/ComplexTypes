using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexType.DataAccess.Abstract;
using ComplexType.Entity.Concrete;

namespace ComplexType.DataAccess.Concrete
{
    public class EfProductDal:EntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on
                        p.CategoryID equals c.CategoryID
                    select new ProductDetail
                    {
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName,
                        ProductID = p.ProductID
                    };
                return result.ToList();
            }
        }
    }
}
