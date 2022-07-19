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
    }
}
