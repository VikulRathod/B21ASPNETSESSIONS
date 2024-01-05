using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.Models;

namespace VCart.BLL.Interfaces
{
    public interface IProductBL
    {
        List<Product> AllProducts();

        Product ProductById(int id);

        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
