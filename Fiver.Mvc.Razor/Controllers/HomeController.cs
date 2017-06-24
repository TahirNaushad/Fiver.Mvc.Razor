using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.Razor.Models.Home;

namespace Fiver.Mvc.Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            var model = new AboutViewModel
            {
                Firstname = "Tahir",
                Surname = "Naushad"
            };
            return View("Bio", model);
        }
    }
}
