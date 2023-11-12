using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myWebsiteApp_JohnMoreau.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace myWebsiteApp_JohnMoreau.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {


        [Route("[area]/[controller]/[action]/Page{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.Title = "Help Page";

            if (id > 0)
            {
                ViewBag.Active = "Tutorial";
                ViewBag.Header = "Tutorial - Page " + id;
                return View("Page" + id);
            }

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