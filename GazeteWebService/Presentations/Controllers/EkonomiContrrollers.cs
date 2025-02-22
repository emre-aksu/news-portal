using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.EkonomiDto;

namespace Presentations.Controllers
{
    [Route("api/ekonomies")]
    [ApiController]
    public class EkonomiContrrollers : ControllerBase
    {
        private readonly IEkonomiManager _eknmiMngr;
        public EkonomiContrrollers(IEkonomiManager eknmiMngr)
        {
            _eknmiMngr = eknmiMngr;
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            EkonomiGetDto ekonomiGetDto = await _eknmiMngr.GetById(id);
            return Ok(ekonomiGetDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoryLiist = await _eknmiMngr.GetAllEkonomi();
            return Ok(categoryLiist);
        }
        [HttpPost]
        public async Task<IActionResult> AddEkonomi([FromBody] EkonomiPostDto dto)
        {
            await _eknmiMngr.AddEkonomi(dto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEkonomi([FromBody] EkonomiPutDto dto)
        {
            await _eknmiMngr.UpdateEkonomi(dto);
            return Ok();    
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEkonomi([FromRoute] int id)
        {
            await _eknmiMngr.DeleteEkonomi(id);
            return Ok();
        }
    }
}
