using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;

namespace ProjetoIntegradorII.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiariesController : ControllerBase
    {
        private readonly IBeneficiaryService _beneficiaryService;

        public BeneficiariesController(IBeneficiaryService beneficiaryService)
        {
            _beneficiaryService = beneficiaryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BeneficiaryDto>>> Get()
        {
            var beneficiaries = await _beneficiaryService.GetBeneficiaries();
            if (beneficiaries == null)
            {
                return NotFound("Beneficiaries not found");
            }
            return Ok(beneficiaries);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<BeneficiaryDto>> GetById(int id)
        {
            var beneficiary = await _beneficiaryService.GetBeneficiaryById(id);
            if (beneficiary == null)
            {
                return NotFound("Beneficiary not found");
            }
            return Ok(beneficiary);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] BeneficiaryDto beneficiaryDto)
        {
            if (beneficiaryDto == null)
            {
                return BadRequest("Invalid data");
            }
            await _beneficiaryService.Add(beneficiaryDto);

            return Ok("Beneficiary created");

        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, [FromBody] BeneficiaryDto beneficiaryDto)
        {
            if (id != beneficiaryDto.Id)
            {
                return BadRequest("Beneficiary not found");
            }
            if (beneficiaryDto == null)
            {
                return BadRequest("Invalid data");
            }

            await _beneficiaryService.Update(beneficiaryDto);

            return Ok(beneficiaryDto);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BeneficiaryDto>> Delete(int id)
        {
            var beneficiary = _beneficiaryService.GetBeneficiaryById(id);

            if (beneficiary == null)
            {
                return NotFound("Beneficiary not found");
            }

            await _beneficiaryService.Remove(id);

            return Ok();

        }




    }

}
