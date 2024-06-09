using APBD_kolokwium.Context;
using APBD_kolokwium.Models;

namespace APBD_kolokwium.Repository;

public class PaymentRepository : IPaymentRepository
{
    private readonly MainDBContext _mainDbContext;

    public PaymentRepository(MainDBContext mainDbContext)
    {
        _mainDbContext = mainDbContext;
    }

    public Payment getPayment(int clientId)
    {
        return _mainDbContext.Payments.Find(clientId);
    }
}
