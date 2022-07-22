using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;
using Microsoft.AspNetCore.Http;

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
            ViewBag.Username = HttpContext.Session.GetString("username");
            ViewBag.Userid = HttpContext.Session.GetInt32("userid");
            var product = db.Products.ToList();
            product = (from p in db.Products
                       where p.Status == 1
                       select p).ToList();
            return View(product);
        }

        [HttpPost]
        public IActionResult Index(string name)
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
