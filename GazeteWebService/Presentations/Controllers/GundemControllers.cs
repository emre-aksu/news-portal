using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.GundemDto;

namespace Presentations.Controllers
{
    [Route("api/gundems")]
    [ApiController]
    public class GundemControllers : ControllerBase
    {
        private readonly IGundemManager _gndMngr;
        public GundemControllers(IGundemManager gndMngr)
        {
            _gndMngr = gndMngr;
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            GundemGetDto gundemGetDto = await _gndMngr.GetById(id);
            return Ok(gundemGetDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGundem()
        {
            var gundemList = await _gndMngr.GetAllGundem();
            return Ok(gundemList);
        }
        [HttpPost]  
        public async Task<IActionResult> AddGundem([FromBody] GundemPostDto dto)
        {
            await _gndMngr.AddGundem(dto);
            return Ok(dto);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGundem([FromBody] GundemPutDto dto)
        {
            await _gndMngr.UpdateGundem(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteGundem([FromRoute] int id)
        {
            await _gndMngr.DeleteGundem(id);
            return Ok();
        }
    }
}
