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
                ViewBag.Map = "Null, please input your username & password";
                return View();
            }
            else
            {
                var User = db.Users.ToList();
                /*
                User = (from p in User
                        where p.UserName == name && p.Password == password
                        select p).ToList();
                HttpContext.Session.SetString("username", name);
                return RedirectToAction("Index", "HomePage");
                */
                
                foreach(User u in db.Users.ToList())
                {
                    if(u.UserName.Equals(name) && u.Password.Equals(password))
                    {
                        HttpContext.Session.SetString("username", u.UserName);
                        HttpContext.Session.SetInt32("userid", u.UserId);
                        break;
                    }

                }
                
                return RedirectToAction("Index", "HomePage");

            }
            


        }
    }
}
