using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    public class AdminController : Controller
    {
        PRN1Context db = new PRN1Context();

        public IActionResult Manager()
        {
            int id = 1;
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

        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Manager");
        }
        
        public IActionResult Update(int id)
        {

            ViewBag.Product = db.Products.Find(id);
            ViewBag.Category = db.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product.ProductName == null || product.Image == null || product.Price == 0 || product.Date.ToString() == "" || product.Detail == null)
                return RedirectToAction("Update");
            db.Products.Update(product);
            db.SaveChanges(true);
            return RedirectToAction("Manager");
        }
    }
}
