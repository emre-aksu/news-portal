using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.OnsozOzelDto;

namespace Presentations.Controllers
{
    [Route("api/onsozs")]
    [ApiController]
    public class OnsozControllers : ControllerBase
    {
        private readonly IOnsozOzelManager _onszMngr;
        public OnsozControllers(IOnsozOzelManager onszMngr)
        {
            _onszMngr = onszMngr;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            OnsozOzelGetDto onsozOzelGetDto = await _onszMngr.GetById(id);
            return Ok(onsozOzelGetDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var onsozList = await _onszMngr.GetAllOnsoz();
            return Ok(onsozList);
        }

        [HttpPost]
        public async Task<IActionResult> AddOnsoz([FromBody] OnsozOzelPostDto dto)
        {
            await _onszMngr.AddOnsoz(dto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOnsoz([FromBody] OnsozOzelPutDto dto)
        {
            await _onszMngr.UpdateOnsoz(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteOnsoz([FromRoute] int Id)
        {
            await _onszMngr.DeleteOnsoz(Id);
            return Ok();
        }

    }
}
