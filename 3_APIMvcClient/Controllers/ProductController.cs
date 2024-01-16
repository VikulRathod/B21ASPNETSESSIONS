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

        [HttpGet]
        public ActionResult Details(int id)
        {
            Product product = new Product();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44344/api/");

            var response = client.GetAsync($"product/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<Product>(json);

                return View(product);
            }

            return View(product);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44344/api/");

            var response = client.PostAsJsonAsync<Product>("product", product).Result;

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("Name", "Error in calling API");

            return View();
        }
    }
}