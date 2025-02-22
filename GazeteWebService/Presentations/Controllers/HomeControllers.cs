using Business.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.HomeDto;

namespace Presentations.Controllers
{
    [Route("api/homes")]
    [ApiController]
    public class HomeControllers : ControllerBase
    {
        private readonly IHomeManager _hmMngr; 
        public HomeControllers(IHomeManager hmMngr)
        {
            _hmMngr = hmMngr;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            HomeGetDto homeGetDto = await _hmMngr.GetById(id);
            return Ok(homeGetDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHome()
        {
            var homeList = await _hmMngr.GetAllHome();
            return Ok(homeList);
        }
        [HttpPost]
        public async Task<IActionResult> AddHome([FromBody] HomePostDto dto)
        {
            await _hmMngr.AddHome(dto);
            return Ok(dto);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateHome([FromBody] HomePutDto dto)
        {
            await _hmMngr.UpdateHome(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteHome([FromRoute] int id)
        {
            await _hmMngr.DeleteHome(id);
            return Ok();

        }
    }
}
