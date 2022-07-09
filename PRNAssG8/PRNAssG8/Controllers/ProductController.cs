﻿using Microsoft.AspNetCore.Mvc;
using PRNAssG8.Models;
using System.Linq;

namespace PRNAssG8.Controllers
{
    public class ProductController : Controller
    {
        PRN1Context db = new PRN1Context();
        public IActionResult Insert()
        {
            ViewBag.cate = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Insert(Product product)
        {
            ViewBag.cate = db.Categories.ToList();
            db.Products.Add(product);
            db.SaveChanges(true);
            return View();
        }
        public IActionResult Detail()
        {
            ViewBag.product = db.Products.ToList();
            ViewBag.cate = db.Categories.ToList();
            return View();
        }
    }
}