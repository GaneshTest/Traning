using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication.DAL;
using MVCApplication.DAL.DataAccess;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private DbManager dbManager = new DbManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();


        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Gallery()
        {
            //var result = dbManager.GetHedMeasures();
            //List<Product> products = new List<Product>();
            //Product product = new Product() { Id = 1, Name = "Laptop" };
            //Product product1 = new Product() { Id = 1, Name = "Laptop" };
            //products.Add(product);
            //products.Add(product1);
            return View();
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}