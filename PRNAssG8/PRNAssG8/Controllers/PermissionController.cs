using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PRNAssG8.Controllers
{
    public class PermissionController : Controller
    {
        public IActionResult Pre()
        {
            HttpContext.Session.Remove("userid");
            HttpContext.Session.Remove("username");

            return RedirectToAction("Tim", "Search");
        }
    }
}
