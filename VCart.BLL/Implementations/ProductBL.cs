using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCart.BLL.Interfaces;
using VCart.Models;
using VCart.Repositories.Interfaces;
using dal = VCart.DAL.Entities;

namespace VCart.BLL.Implementations
{
    public class ProductBL : IProductBL
    {
        IProductRepository _productRepo = null;

        public ProductBL(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public List<Product> AllProducts()
        {
            var products = _productRepo.AllProducts()
                ?.Select(p => new Product()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Image = p.Image,
                    AddedDate = p.AddedDate
                });

            return products?.ToList();
        }

        public bool CreateProduct(Product product)
        {
            dal.Product p = new dal.Product()
            {
                Name = product.Name,
                Price = product.Price,
                Image = product.Image,
                AddedDate = product.AddedDate
            };

            return _productRepo.CreateProduct(p);
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
