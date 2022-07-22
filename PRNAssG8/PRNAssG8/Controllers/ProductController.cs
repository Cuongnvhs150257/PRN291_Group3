using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System;
using System.Linq;

namespace PRNAssG8.Controllers
{
    public class ProductController : Controller
    {
        PRN2Context db = new PRN2Context();
        public IActionResult Insert()
        {
            ViewBag.cate = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Product product)
        {
            if(product.ProductName==null||product.Image == null || product.Price==0 || product.Date.ToString() == "" || product.Detail == null)
                return RedirectToAction("Insert");
            ViewBag.cate = db.Categories.ToList();
            db.Products.Add(product);
            db.SaveChanges(true);
            return View();
        }
        public IActionResult Detail(int id)
        {
            ViewBag.re =(from r in db.Reservations
                         where r.ProductId==id
                         orderby r.NewPrice descending
                         
                         select  r).Take(15).ToList();
            ViewBag.res = db.Reservations.ToList();
            ViewBag.user = db.Users.ToList();
            ViewBag.cate = db.Categories.ToList();
            ViewBag.product = db.Products.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Detail( Reservation reservation,int check)
        {       
                Product product = db.Products.Find(reservation.ProductId);
                product.Price = (double)reservation.NewPrice;
                db.Products.Update(product);

                if(check==1)
                    db.Reservations.Update(reservation);
                else
                    db.Reservations.Add(reservation);
     
                db.SaveChanges(true);
            
            return RedirectToAction("Detail");
        }
    }
}
