using _1_Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1_Intro.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IEnumerable<Product> AllProducts()
        {
            ProductBL bl = new ProductBL();
            return bl.AllProducts();
        }

        [HttpGet]
        public Product GetById(int id)
        {
            ProductBL bl = new ProductBL();
            return bl.AllProducts().FirstOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            // code to insert product
        }

        [HttpPut]
        public void UpdateProduct(int id,  Product product)
        {
            // code to update product
        }

        [HttpDelete]
        public void DeleteProduct(int id)
        {
            // code to delete product
        }

    }
}
