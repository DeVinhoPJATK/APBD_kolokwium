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
        var payment = _paymentRepository.getPayment(clientId);

        throw new NotImplementedException();
    }
}
