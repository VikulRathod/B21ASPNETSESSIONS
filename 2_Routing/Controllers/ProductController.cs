using _2_Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _2_Routing.Controllers
{
    public class ProductController : ApiController
    {
        ProductDbContext _db = new ProductDbContext();

        //[HttpGet]
        //public IEnumerable<Product> GetAllProducts()
        //{
        //    return _db.Products.ToList();
        //}

        //[HttpGet]
        //public HttpResponseMessage GetAllProducts()
        //{
        //    var products = _db.Products.ToList();

        //    return Request.CreateResponse(HttpStatusCode.OK, products);
        //}

        [HttpGet]
        public IHttpActionResult GetAllProducts()
        {
            var products = _db.Products.ToList();
            return Ok(products);
        }

        [HttpGet]
        public IHttpActionResult GetProductById(int id)
        {
            if (id < 0)
            {
                return BadRequest("Id cannot be negative"); // 400 code
            }

            Product product = _db.Products.Find(id);

            if (product == null)
            {
                return NotFound(); // 404
            }
            else
            {
                return Ok(product);
            }
        }


        [HttpPost]
        public IHttpActionResult CreateProduct(Product product)
        {
            if (product != null && !string.IsNullOrEmpty(product.Name))
            {
                _db.Products.Add(product);
                _db.SaveChanges();

                return Created("DefaultApi", product);
            }
            else
            {
                return BadRequest(); // 400
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateProduct(int id, Product product)
        {
            if (product == null)
            {
                return BadRequest("Pass correct product details to update");
            }

            if (id != product.Id)
            {
                return BadRequest("Product Id should be same");
            }

            Product dbProduct = _db.Products.Find(id);
            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.Image = product.Image;

            _db.SaveChanges();

            return Ok(); // 200
        }

        [HttpDelete]
        public IHttpActionResult DeleteProduct(int id)
        {
            if (id < 0)
            {
                return BadRequest("Product Id cannot be negative");
            }

            Product product = _db.Products.Find(id);
            if (product != null)
            {
                _db.Products.Remove(product);
                _db.SaveChanges();
                return Ok("Product Deleted Successfully");
            }

            return NotFound(); // 404
        }
    }
}
