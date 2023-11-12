using Microsoft.AspNetCore.Mvc;
using myWebsiteApp_JohnMoreau.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace myWebsiteApp_JohnMoreau.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {

        [Route("[area]/[controller]")]
        public IActionResult Index()
        {
            ViewBag.Title = "Help Page";
            ViewBag.Active = "Home";
            ViewBag.Header = "Tutorial Home";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}