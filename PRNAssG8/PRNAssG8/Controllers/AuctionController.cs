using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;


namespace PRNAssG8.Controllers
{
    [Route("auction")]
    public class AuctionController : Controller
    {
        PRN2Context db = new PRN2Context();

        public IActionResult Index(int id)
        {
            ViewBag.Products = db.Products.ToList();
            //lay ra nhung product co proid = proid da chon
            var product = db.Products.ToList();
            if (id != 0)
            {
                product = (from p in db.Products
                           where p.ProductId == id
                           select p).ToList();

            }
            return View(product);
        }
 
    }
}
