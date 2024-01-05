﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VCart.BLL.Interfaces;
using VCart.Models;

namespace VCart.Web.Controllers
{
    public class ProductsController : Controller
    {
        IProductBL _productBL = null;

        public ProductsController(IProductBL productBL)
        {
            _productBL = productBL;
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = _productBL.AllProducts();

            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product, HttpPostedFileBase ImageFile)
        {
            if(ImageFile != null)
            {
                string path = Server.MapPath("~/Images/" + ImageFile.FileName);
                ImageFile.SaveAs(path);

                product.Image = ImageFile.FileName;
            }

            product.AddedDate = DateTime.Now;

            bool status = _productBL.CreateProduct(product);
            if (status)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}