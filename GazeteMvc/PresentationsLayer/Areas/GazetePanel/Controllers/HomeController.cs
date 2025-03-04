using Microsoft.AspNetCore.Mvc;
using PresentationsLayer.ApiServices;
using PresentationsLayer.Areas.GazetePanel.ApiTypes;

using ModelLayer.Dtos;
using System.Text.Json;


namespace PresentationsLayer.Areas.GazetePanel.Controllers
{
    [Area("GazetePanel")]
    public class HomeController : Controller
    {
        private readonly IApiService _apiService; 
        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
        }
       
    }
}
