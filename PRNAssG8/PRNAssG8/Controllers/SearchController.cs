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
            return View();
        }

    }
}
