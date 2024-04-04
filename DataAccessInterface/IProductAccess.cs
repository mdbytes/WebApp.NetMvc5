using DataObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface IProductAccess
    {
        List<ProductVM> GetProucts();

        ProductVM GetProductById(int id);

        bool AddProduct(ProductVM product);

        bool UpdateProduct(ProductVM product);

        bool DeleteProduct(int id);

    }
}
