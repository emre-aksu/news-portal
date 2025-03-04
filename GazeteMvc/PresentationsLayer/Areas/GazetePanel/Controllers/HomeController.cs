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
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var viewModel = await _apiService.GetData<List<EkonomiResponse>>("ekonomi",token:null);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(EkonomiAddDto dto)
        {
            var requestObject = new EkonomiPostRequest
            {
                Name = dto.Name,
                Description = dto.Description,
                PhotoPath = dto.PhotoPath
            };

            var rootPath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\ekonomiImages\\";
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.Photo.FileName)}";

            using (var fs = new FileStream($"{rootPath}{fileName}", FileMode.Create))
            {
                await dto.Photo.CopyToAsync(fs);
                requestObject.PhotoPath = $@"\ekonomiImages\{fileName}";
                fs.Close();
            }
            string jsonPostData = JsonSerializer.Serialize(requestObject);
            var postResult = await _apiService.PostData("ekonomi", jsonPostData, token: null);

            if(postResult)
            
                return RedirectToAction("List");
                     
            return Json(new { IsSuccess = false });
        }
    }
}
