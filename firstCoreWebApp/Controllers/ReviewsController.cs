using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstCoreWebApp.Controllers
{
    public class ReviewsController : Controller
    {
        public IActionResult Index()
        {
            
                ViewBag.ReviewList = Review.reviewList;

       
            return View();
        }
        [HttpGet]
        public IActionResult Create()

        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Create(string info)

        {
            if (string.IsNullOrWhiteSpace(info))
            {
                ViewBag.Msg = "You must enter some text.";
                return View();
            }

            else
            {
                Review.reviewList.Add(new Review() { Info = info });

                return RedirectToAction("Index");

            }
        }
    }
}