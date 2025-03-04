using Microsoft.AspNetCore.Mvc;

namespace PresentationsLayer.Areas.GazetePanel.Controllers
{
    public class SporController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
