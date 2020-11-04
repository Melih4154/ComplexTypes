using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexType.DataAccess.Abstract;
using ComplexType.Entity.Concrete;

namespace ComplexType.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<ProductDetail> ProductDetails();
    }
}
