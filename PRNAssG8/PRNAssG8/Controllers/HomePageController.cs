using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    [Route("homepage")]

    public class HomePageController : Controller
    {

        PRN2Context db = new PRN2Context();
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            
            var product = db.Products.ToList();
            product = (from p in db.Products
                       where p.Status == 1
                       select p).ToList();
            if(product == null)
                return View();
            return View(product);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            var product = db.Products.ToList();
            if (name != null)
            {

                product = (from p in db.Products
                             where p.ProductName.Contains(name)
                             select p).ToList();
            }


            return View(product);
        }
    }
}
