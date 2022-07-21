using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System.Linq;

namespace PRNAssG8.Controllers
{
    public class SearchController : Controller
    {
        PRN1Context db = new PRN1Context();
        public IActionResult Tim()
        {
            var product = db.Products.ToList();
            product = (from p in db.Products
                       where p.Status == 1
                       select p).ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Tim(Product product)
        {
            string Pro = product.ProductName.ToString();
            var productSe = db.Products.ToList();
            if (product.ProductName.ToString() != null)
            {
                
                productSe = (from p in db.Products
                           where p.ProductName == Pro
                           select p).ToList();
            }
             

            return View(productSe); 
        }
    }
}
