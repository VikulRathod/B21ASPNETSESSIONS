using _3_APIMvcClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace _3_APIMvcClient.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            // api call 
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44344/api/");

            HttpResponseMessage response = client.GetAsync("product").Result;

            if (response.IsSuccessStatusCode)
            {
                // deserialize

                string jsonResult = response.Content.ReadAsStringAsync().Result;

                products = JsonConvert.DeserializeObject<List<Product>>(jsonResult);

                return View(products);
            }
            else
            {
                return View(products);
            }
        }
    }
}