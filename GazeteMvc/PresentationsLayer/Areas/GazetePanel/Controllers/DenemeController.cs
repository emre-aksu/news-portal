using Microsoft.AspNetCore.Mvc;

namespace PresentationsLayer.Areas.GazetePanel.Controllers
{
    [Area("GazetePanel")]
    public class DenemeController : Controller
    {
        [HttpGet]   
        public IActionResult List()
        
        {
            return View();
        }
    }
}
