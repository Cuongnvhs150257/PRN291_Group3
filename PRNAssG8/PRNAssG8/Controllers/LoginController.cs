using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System.Linq;


namespace PRNAssG8.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Lo()
        {
            return View();
        }
    }
}
