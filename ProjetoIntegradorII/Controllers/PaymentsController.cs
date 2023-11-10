using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;

namespace ProjetoIntegradorII.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDto>>> Get()
        {
            var payments = await _paymentService.GetPayments();
            if(payments == null)
            {
                return NotFound("Payments not found");
            }

            return Ok(payments);
        }

        [HttpGet("getbyid/{id}")]
        public async Task<ActionResult<PaymentDto>> GetByid(int id)
        {
            var payment = await _paymentService.GetPaymentById(id);
            if(payment == null)
            {
                return NotFound("payment not found");
            }
            return Ok(payment);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PaymentDto paymentDto)
        {
            if (paymentDto == null)
            {
                return BadRequest("invalid data");
            }

            await _paymentService.Add(paymentDto);

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> put(int id, [FromBody] PaymentDto paymentDto)
        {
            if (id != paymentDto.Id)
            {
                return BadRequest("invalid data");
            }
            if (paymentDto == null)
            {
                return BadRequest("invalid data");
            }
            
            await _paymentService.Update(paymentDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentDto>> Delete(int id)
        {
            var payment = _paymentService.GetPaymentById(id);
            
            if (payment == null)
            {
                return NotFound("Payment not found");
            }

            await _paymentService.Remove(id);

            return Ok();
        }
    }
}
