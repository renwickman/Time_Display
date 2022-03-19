using Microsoft.AspNetCore.Mvc;
using System;

namespace TimeDisplay2
{
    
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index(){
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime.ToString("h:mm tt");
            ViewBag.Date = CurrentTime.ToString("dddd MMMM dd, yyyy");
            return View("Index");
        }

    }
}