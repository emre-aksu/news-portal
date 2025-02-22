using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.ResmiIlanlarDto;

namespace Presentations.Controllers
{
    [Route("api/resmies")]
    [ApiController]
    public class ResmiIlanlarController : ControllerBase
    {
        private readonly IResmiIlanlarManager _rsmMngr;
        public ResmiIlanlarController(IResmiIlanlarManager rsmMngr)
        {
            _rsmMngr = rsmMngr;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            ResmiIlanlarGetDto resmiIlanlarGetDto = await _rsmMngr.GetById(Id);
            return Ok(resmiIlanlarGetDto);
        }
        [HttpGet]
        public async Task<IActionResult> GelAllResmi()
        {
            var resmiList = await _rsmMngr.GetAllResmi();
            return Ok(resmiList);
        }
        [HttpPost]
        public async Task<IActionResult> AddResmi([FromBody] ResmiIlanlarPostDto dto)
        {
            await _rsmMngr.AddResmi(dto);
            return Ok();    
        }
        [HttpPut]
        public async Task<IActionResult> UpdateResmi([FromBody] ResmiIlanlarPutDto dto)
        {
            await _rsmMngr.UpdateResmi(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteResmi([FromRoute] int Id)
        {
            await _rsmMngr.DeleteResmi(Id);
            return Ok();
        }

    }
}
