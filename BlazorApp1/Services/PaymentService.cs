using BlazorApp1.CarModels;
using BlazorApp1.Repositories;

namespace BlazorApp1.Services
{
    public class PaymentService
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentService(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<IEnumerable<Payment>> GetPaymentsAsync()
        {
            return await _paymentRepository.GetAllAsync();
        }

        public async Task AddPaymentAsync(Payment payment)
        {
            await _paymentRepository.AddAsync(payment);
        }

        // Additional methods as needed
    }

}
