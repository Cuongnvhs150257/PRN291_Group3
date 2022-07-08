using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PRNAssG8.Models;

namespace PRNAssG8.Controllers
{
    public class HomePageController : Controller
    {
        PRN1Context db = new PRN1Context();
        public IActionResult Index()
        {
            return View();
        }
    }
}
