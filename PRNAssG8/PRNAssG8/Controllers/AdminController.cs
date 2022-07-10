using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        PRN1Context db = new PRN1Context();

        public IActionResult Index(int id = 3)
        {
            //lay ra nhung product co cateid = cateid da chon
            var product = db.Products.ToList();
            if (id != 0)
            {
                product = (from p in db.Products
                           where p.UserId == id
                           select p).ToList();

            }
            return View(product);
            
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(int id)
        {
            
            var products = db.Products.Find(id);
            ViewBag.Product = db.Products.ToList();
            ViewBag.Category = db.Categories.ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Product = db.Products.ToList();
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
