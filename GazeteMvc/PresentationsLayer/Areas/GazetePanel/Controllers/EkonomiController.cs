using Microsoft.AspNetCore.Mvc;
using ModelLayer.Dtos.EkonomiDto;
using PresentationsLayer.ApiServices;
using PresentationsLayer.Areas.GazetePanel.ApiTypes;
using System.Text.Json;

namespace PresentationsLayer.Areas.GazetePanel.Controllers
{
    [Area("GazetePanel")]
    public class EkonomiController : Controller
    {
        private readonly IApiService _apiService;
        public EkonomiController(IApiService apiService)
        {
            _apiService = apiService;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var viewModel = await _apiService.GetData<List<EkonomiResponse>>("ekonomi", token: null);
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

            if (postResult)

                return RedirectToAction("List");

            return Json(new { IsSuccess = false });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var ekonomi = await _apiService.GetData<EkonomiResponse>($"ekonomi/{id}", token: null);
            return View(ekonomi);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EkonomiEditDto dto)
        {
            var requestObject = new EkonomiPutRequest
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
                PhotoPath = dto.PhotoPath
            };

            var roorPath = $"{Directory.GetCurrentDirectory()}\\wwwroot\\ekonomiImages\\";
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.Photo.FileName)}";
            using (var fs = new FileStream($"{roorPath}{fileName}", FileMode.Create))
            {
                await dto.Photo.CopyToAsync(fs);
                requestObject.PhotoPath = $@"\ekonomiImages\{fileName}";
                fs.Close();
            }
            string jsonPutData = JsonSerializer.Serialize(requestObject);
            var putResult = await _apiService.PutData($"ekonomi/{dto.Id}", jsonPutData, token: null);
            if (putResult)
                return RedirectToAction("List");

            else
                throw new Exception("Güncelleme işlemi başarısız oldu");


        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteResult = await _apiService.DeleteData($"ekonomi/{id}", token: null);
            if (deleteResult)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false });
        }
    }
}
