using AutoMapper;
using ProjetoIntegradorII.Application.DTOs;
using ProjetoIntegradorII.Application.Interfaces;
using ProjetoIntegradorII.Domain.Entities;
using ProjetoIntegradorII.Domain.Interfaces;

namespace ProjetoIntegradorII.Application.Services
{
    public class PaymentService : IPaymentService
    {
        private IPaymentRepository _paymentRepository;

        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentDto>> GetPayments()
        {
            var paymentsEntity = await _paymentRepository.GetPayments();
            return _mapper.Map<IEnumerable<PaymentDto>>(paymentsEntity);
        }

        public async Task<PaymentDto> GetPaymentById(int? id)
        {
            var paymentEntity = await _paymentRepository.GetPaymentById(id);
            return _mapper.Map<PaymentDto>(paymentEntity);
        }

        public async Task<PaymentDto> Add(PaymentDto paymentDto)
        {
            var paymentEntity = _mapper.Map<Payment>(paymentDto);
            await _paymentRepository.Create(paymentEntity);
            return _mapper.Map<PaymentDto>(paymentEntity);
        }

        public async Task<PaymentDto> Update(PaymentDto paymentDto)
        {
            var paymentEntity = _mapper.Map<Payment>(paymentDto);
            await _paymentRepository.Update(paymentEntity);
            return _mapper.Map<PaymentDto>(paymentEntity);
        }

        public async Task Remove(int id)
        {
            var paymentEntity = await _paymentRepository.GetPaymentById(id);
            if (paymentEntity != null)
            {
                await _paymentRepository.Remove(paymentEntity);
            }
        }
    }
}
