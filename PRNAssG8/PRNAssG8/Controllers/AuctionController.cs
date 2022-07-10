using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;


namespace PRNAssG8.Controllers
{
    [Route("auction")]
    public class AuctionController : Controller
    {
        PRN1Context db = new PRN1Context();
        
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        [HttpPost]
        public IActionResult ShowAuction(int ProId)
        {
            //lay ra nhung product co proid = proid da chon
            var product = db.Products.ToList();
            if (ProId != 0)
            {
                product = (from p in db.Products
                           where p.ProductId == ProId
                           select p).ToList();

            }
            return View(product);
        }
    }
}
