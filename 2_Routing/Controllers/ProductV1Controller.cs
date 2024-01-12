using _2_Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace _2_Routing.Controllers
{
    public class ProductV1Controller : ApiController
    {
        ProductDbContext _db = new ProductDbContext();

        [HttpGet]
        [ResponseType(typeof(IEnumerable<Product>))]
        public IHttpActionResult GetProducts()
        {
            var products = _db.Products.ToList();
            return Ok(products);
        }

        // manage call
        [HttpPost]
        public IHttpActionResult ManageProduct(Product product)
        {
            if(product != null)
            {
                if(product.IsCreate && product.IsUpdate && product.IsDelete)
                {
                    return BadRequest("Create, Update and Delete cannot be done at same time");
                }
                else if(product.IsCreate && (!product.IsUpdate && !product.IsDelete))
                {
                    _db.Products.Add(product);
                    _db.SaveChanges();
                    return Created("DefaultApi", product);
                }
                else if(product.IsUpdate && (!product.IsCreate && !product.IsDelete))
                {
                    var dbProduct = _db.Products.Find(product.Id);
                    dbProduct.Name = product.Name;
                    dbProduct.Price = product.Price;

                    _db.SaveChanges();
                    return Ok();
                }
                else if(product.IsDelete && (!product.IsCreate && !product.IsUpdate))
                {
                    var dbProduct = _db.Products.Find(product.Id);

                    _db.Products.Remove(dbProduct);
                    _db.SaveChanges();

                    return Ok();
                }
                else
                {
                    return BadRequest("Select at least one create or update or delete operation");
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
