using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;

namespace ProjetoIntegradorII.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly ITitleService _titleService;

        public TitlesController(ITitleService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TitleDto>>> Get()
        {
            var titles = await _titleService.GetTitles();
            if(titles == null)
            {
                return NotFound("Titles not found");
            }

            return Ok(titles);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<TitleDto>> GetById(int id)
        {
            var title = await _titleService.GetById(id);
            if(title == null)
            {
                return NotFound("Title not found");
            }
            return Ok(title);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TitleDto titleDto)
        {
            if(titleDto == null)
            {
                return BadRequest("Invalid data");
            }
            await _titleService.Add(titleDto);

            return Ok("Title created");
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] TitleDto titleDto)
        {
            if(id != titleDto.Id)
            {
                return BadRequest("id not found");
            }
            if(titleDto == null)
            {
                return BadRequest("Invalid data");
            }

            await _titleService.Update(titleDto);
            
            return Ok(titleDto);
        }

        [HttpDelete]
        public async Task<ActionResult<TitleDto>> Delete(int id)
        {
            var title = _titleService.GetById(id);
            if(title == null)
            {
                return NotFound("Title not found");
            }

            await _titleService.Remove(id);

            return Ok("Title removed");
        }

    }
}
