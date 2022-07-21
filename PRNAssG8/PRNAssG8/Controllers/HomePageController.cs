using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    [Route("homepage")]

    public class HomePageController : Controller
    {

        PRN1Context db = new PRN1Context();
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            var product = db.Products.ToList();
            product = (from p in db.Products
                       where p.Status == 1
                       select p).ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Index(Product productSe)
        {
            string Pro = productSe.ProductName.ToString();
            var product = db.Products.ToList();
            if (productSe.ProductName.ToString() != null)
            {

                product = (from p in db.Products
                             where p.ProductName == Pro
                             select p).ToList();
            }


            return View(product);
        }
    }
}
