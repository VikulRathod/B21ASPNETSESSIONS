using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3_APIMvcClient.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
    }
}