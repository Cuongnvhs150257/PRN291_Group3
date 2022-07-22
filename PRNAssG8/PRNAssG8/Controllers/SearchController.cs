using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System.Linq;

namespace PRNAssG8.Controllers
{
    public class SearchController : Controller
    {
        PRN2Context db = new PRN2Context();
        public IActionResult Tim()
        {
            var product = db.Products.ToList();
            product = (from p in db.Products
                       where p.Status == 1
                       select p).ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Tim(string name)
        {
    
            var productSe = db.Products.ToList();
            if (name != null)
            {

                productSe = (from p in db.Products
                             where p.ProductName.Contains(name)
                             select p).ToList();
            }
             

            return View(productSe); 
        }
    }
}
