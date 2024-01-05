using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;

namespace VCart.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> AllProducts();

        Product ProductById(int id);

        bool CreateProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
    }
}
