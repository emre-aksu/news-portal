using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.SporDto;

namespace Presentations.Controllers
{
    [Route("api/spors")]
    [ApiController]
    public class SporControllers : ControllerBase
    {
        private readonly ISporManager _sprMngr;
        public SporControllers(ISporManager sprMngr)
        {
             _sprMngr = sprMngr;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            SporGetDto sporGetDto = await _sprMngr.GetById(id);
            return Ok(sporGetDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSpor()
        {
            var sporList = await _sprMngr.GetAllSpor();
            return Ok(sporList);
        }
        [HttpPost]
        public async Task<IActionResult> AddSpor([FromBody] SporPostDto dto)
        {
            await _sprMngr.AddSpor(dto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSpor([FromBody] SporPutDto dto)
        {
            await _sprMngr.UpdateSpor(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteSpor([FromRoute] int Id)
        {
            await _sprMngr.DeleteSpor(Id);
            return Ok();
        }
    }
}
