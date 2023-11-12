using Microsoft.AspNetCore.Mvc;
using myWebsiteApp_JohnMoreau.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace myWebsiteApp_JohnMoreau.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {


        [Route("[area]/[controller]s/{id?}")]
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }


        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Phone"] = "555-123-4567";
            ViewData["Email"] = "me@mywebsite.com";
            ViewData["Facebook"] = "facebook.com/mywebsite";
            ViewBag.Title = "Contact";
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}