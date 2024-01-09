using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1_Intro.Models
{
    public class ProductBL
    {
        public List<Product> AllProducts()
        {
            return new List<Product>()
            {
            new Product(){ Id = 1, Name = "Shirt", Price = 999},
            new Product(){ Id = 2, Name = "T-Shirt", Price = 299},
            new Product(){ Id = 3, Name = "Shoe", Price = 1500}
            };
        }
    }
}