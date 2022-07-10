using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        PRN1Context db = new PRN1Context();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}
