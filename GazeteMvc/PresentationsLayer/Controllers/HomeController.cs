using Microsoft.AspNetCore.Mvc;

namespace PresentationsLayer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
