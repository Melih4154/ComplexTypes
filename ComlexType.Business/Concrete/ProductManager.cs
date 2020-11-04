using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexType.Business.Abstract;
using ComplexType.DataAccess.Abstract;
using ComplexType.Entity.Concrete;

namespace ComlexType.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetProducts();
        }

        public List<ProductDetail> ProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
