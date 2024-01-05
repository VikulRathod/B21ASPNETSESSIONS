using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.DAL.Entities;
using VCart.Repositories.Interfaces;

namespace VCart.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        ProductDbContext _db = null;

        public ProductRepository(ProductDbContext db)
        {
            _db = db;
        }

        public List<Product> AllProducts()
        {
            return _db.Products?.ToList();
        }

        public bool CreateProduct(Product product)
        {
            try
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product ProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
