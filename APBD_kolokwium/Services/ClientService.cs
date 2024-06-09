using APBD_kolokwium.Dto;
using APBD_kolokwium.Repository;

namespace APBD_kolokwium.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IPaymentRepository _paymentRepository;

    public ClientService(IClientRepository clientRepository, IPaymentRepository paymentRepository)
    {
        _clientRepository = clientRepository;
        _paymentRepository = paymentRepository;
    }

    public ClientSubscriptionsDto FetchClientSubscriptions(int clientId)
    {
        // var client = _clientRepository.GetClient(clientId);
        var payment = _paymentRepository.getPayment(clientId);

        return new ClientSubscriptionsDto
        {
            FirstName = payment.Client.FirstName,
            LastName = payment.Client.LastName,
            Email = payment.Client.Email,
            Phone = payment.Client.Phone,
            Discount = 0,
            Subscriptions = null
        };
    }
}
