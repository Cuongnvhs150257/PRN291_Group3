using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System.Linq;


namespace PRNAssG8.Controllers
{
    public class LoginController : Controller
    {
        PRN2Context db = new PRN2Context();
        public IActionResult Lo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lo(string name, string password)
        {
            

            if(name == null || password == null)
            {
                return View();
            }
            else
            {
                var User = db.Users.ToList();

                User u = (User) (from p in User
                        where p.UserName == name && p.Password == password
                        select p);
                HttpContext.Session.SetString("username", u.FullName);
                HttpContext.Session.SetInt32("userid",u.UserId);
                return View();
            }
            


        }
    }
}
