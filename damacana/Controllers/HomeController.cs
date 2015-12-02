using damacana.Models;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace damacana.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Erikli 19L";
            product1.Price = (decimal)7.90;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Erikli 15L";
            product2.Price = (decimal)6.90;

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);

            return View();
        }

        public ActionResult AddProduct()
        {
            Product product = new Product();
            product.Name = "";
            product.Price = (decimal)0;



            return View(product);
        }

        public ActionResult SaveProduct()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product= Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = Product.Find(id);
           List<Products>.Remove(product);
            SaveChanges();
            return RedirectToAction("Index");
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

       
    }
}