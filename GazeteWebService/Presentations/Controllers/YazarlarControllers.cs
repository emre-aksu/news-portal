using Business.Contracts;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos.YazarlarDto;
using Model.Model;

namespace Presentations.Controllers
{
    [Route("api/yazarlars")]
    [ApiController]
    public class YazarlarControllers : ControllerBase
    {
        private readonly IYazarlarManager _yzrMngr;
        public YazarlarControllers(IYazarlarManager yzrMngr)
        {
            _yzrMngr = yzrMngr;
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            YazarlarGetDto yazarlars = await _yzrMngr.GetById(id);
            return Ok(yazarlars);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var yazarList = await _yzrMngr.GetAllyazarlar();
            return Ok(yazarList);
        }
        [HttpPost]
        public async Task<IActionResult> AddYazar([FromBody] YazarlarPostDto dto)
        {
            await _yzrMngr.AddYazarlar(dto);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateYazar(YazarlarPutDto dto)
        {
            await _yzrMngr.UpdateYazarlar(dto);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteYazarlar([FromRoute] int Id)
        {
            await _yzrMngr.DeleteYazarlar(Id);
            return Ok();    

        }
    }
}
